
--指向当前要使用的数据库
use master
go
--判断当前数据库是否存在
if exists (select * from sysdatabases where name='SMDB')
drop database SMDB --删除数据库
go
--创建数据库
create database SMDB
on primary
(
	--数据库文件的逻辑名
    name='SMDB_data',
    --数据库物理文件名（绝对路径）
    filename='C:\Data\DB\SMDB_data.mdf',
    --数据库文件初始大小
    size=10MB,
    --数据文件增长量
    filegrowth=1MB
)
--创建日志文件
log on
(
    name='SMDB_log',
    filename='C:\Data\DB\SMDB_log.ldf',
    size=2MB,
    filegrowth=1MB
)
go
--创建学员信息数据表
use SMDB
go
if exists (select * from sysobjects where name='Students')
drop table Students
go
create table Students
(
    StudentId int identity(100000,1) ,
    StudentName varchar(20) not null,
    Gender char(2)  not null,
    Birthday smalldatetime  not null,
    StudentIdNo numeric(18,0) not null,--身份证号
    CardNo  varchar(20) not null,--考勤卡号
    StuImage text null,--学员照片
    Age int not null,
    PhoneNumber varchar(50),
    StudentAddress varchar(500),
    ClassId int not null  --班级外键
)
go
--创建班级表
if exists(select * from sysobjects where name='StudentClass')
drop table StudentClass
go
create table StudentClass
(
	ClassId int primary key,
    ClassName varchar(20) not null
)
go
--创建成绩表
if exists(select * from sysobjects where name='ScoreList')
drop table ScoreList
go
create table ScoreList
(
    Id int identity(1,1) primary key,
    StudentId int not null,
    CSharp int null,
    SQLServerDB int null,
    UpdateTime smalldatetime not null
)
go
--创建考勤表
if exists(select * from sysobjects where name='Attendance')
drop table Attendance
create table Attendance
(
	Id int identity(100000,1) primary key,--标识列
    CardNo varchar(20) not null,--学员卡号
    DTime smalldatetime not null --打卡时间
)
go
--创建管理员用户表
if exists(select * from sysobjects where name='Admins')
drop table Admins
create table Admins
(
	LoginId int identity(1000,1) primary key,
    LoginPwd varchar(20) not null,
    AdminName varchar(20) not null
)
go

--创建数据表的各种约束
use SMDB
go
--创建“主键”约束primary key
if exists(select * from sysobjects where name='pk_StudentId')
alter table Students drop constraint pk_StudentId

alter table Students
add constraint pk_StudentId primary key (StudentId)

--创建检查约束check
if exists(select * from sysobjects where name='ck_Age')
alter table Students drop constraint ck_Age
alter table Students
add constraint ck_Age check (Age between 18 and 35) 

--创建唯一约束unique
if exists(select * from sysobjects where name='uq_StudentIdNo')
alter table Students drop constraint uq_StudentIdNo
alter table Students
add constraint uq_StudentIdNo unique (StudentIdNo)

if exists(select * from sysobjects where name='uq_CardNo')
alter table Students drop constraint uq_CardNo
alter table Students
add constraint uq_CardNo unique (CardNo)

--创建身份证的长度检查约束
if exists(select * from sysobjects where name='ck_StudentIdNo')
alter table Students drop constraint ck_StudentIdNo
alter table Students
add constraint ck_StudentIdNo check (len(StudentIdNo)=18)

--创建默认约束 
if exists(select * from sysobjects where name='df_StudentAddress')
alter table Students drop constraint df_StudentAddress
alter table Students 
add constraint df_StudentAddress default ('地址不详' ) for StudentAddress

if exists(select * from sysobjects where name='df_UpdateTime')
alter table ScoreList drop constraint df_UpdateTime
alter table ScoreList 
add constraint df_UpdateTime default (getdate() ) for UpdateTime

if exists(select * from sysobjects where name='df_DTime')
alter table Attendance drop constraint df_DTime
alter table Attendance 
add constraint df_DTime default (getdate() ) for DTime

--创建外键约束
if exists(select * from sysobjects where name='fk_classId')
alter table Students drop constraint fk_classId
alter table Students
add constraint fk_classId foreign key (ClassId) references StudentClass(ClassId)

if exists(select * from sysobjects where name='fk_StudentId')
alter table ScoreList drop constraint fk_StudentId
alter table ScoreList
add constraint fk_StudentId foreign key(StudentId) references Students(StudentId)


-------------------------------------------插入数据--------------------------------------
use SMDB
go

--插入班级数据
insert into StudentClass(ClassId,ClassName) values(1,'软件1班')
insert into StudentClass(ClassId,ClassName) values(2,'软件2班')
insert into StudentClass(ClassId,ClassName) values(3,'计算机1班')
insert into StudentClass(ClassId,ClassName) values(4,'计算机2班')
insert into StudentClass(ClassId,ClassName) values(5,'网络1班')
insert into StudentClass(ClassId,ClassName) values(6,'网络2班')

--插入学员信息
insert into Students (StudentName,Gender,Birthday,Age,StudentIdNo,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('王小虎','男','1989-08-07',22,120223198908071111,'0004018766','022-22222222','天津市南开区红磡公寓5-5-102',1)
insert into Students (StudentName,Gender,Birthday,Age,StudentIdNo,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('贺小张','女','1989-05-06',22,120223198905062426,'0006394426','022-33333333','天津市河北区王串场58号',2)
insert into Students (StudentName,Gender,Birthday,Age,StudentIdNo,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('马小李','男','1990-02-07',21,120223199002078915,'0006073516','022-44444444','天津市红桥区丁字沽曙光路79号',4)
insert into Students (StudentName,Gender,Birthday,Age,StudentIdNo,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('冯小强','女','1987-05-12',24,130223198705125167,'0006254540','022-55555555',default,2)
insert into Students (StudentName,Gender,Birthday,Age,StudentIdNo,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('杜小丽','女','1986-05-08',25,130223198605081528,'0006403803','022-66666666','河北衡水路北道69号',1)
insert into Students (StudentName,Gender,Birthday,Age,StudentIdNo,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('王俊桥','男','1987-07-18',24,130223198707182235,'0006404372','022-77777777',default,1)
insert into Students (StudentName,Gender,Birthday,Age,StudentIdNo,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('张永利','男','1988-09-28',24,130223198909282235,'0006092947','022-88888888','河北保定市风华道12号',3)
insert into Students (StudentName,Gender,Birthday,Age,StudentIdNo,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('李铭','男','1987-01-18',24,130223198701182257,'0006294564','022-99999999','河北邢台市幸福路5号',1)
insert into Students (StudentName,Gender,Birthday,Age,StudentIdNo,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('宁俊燕','女','1987-06-15',24,130223198706152211,'0006092450','022-11111111',default,3)
insert into Students (StudentName,Gender,Birthday,Age,StudentIdNo,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('刘玲玲','女','1989-08-19',24,130223198908192235,'0006069457','022-11111222',default,4)
         
         insert into Students (StudentName,Gender,Birthday,Age,StudentIdNo,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('王小军','女','1986-05-08',25,130224198605081528,'0006403820','022-66666666','河北衡水路北道69号',1)
         insert into Students (StudentName,Gender,Birthday,Age,StudentIdNo,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('刘小丽','女','1986-05-08',25,130225198605081528,'0006403821','022-66666666','河北衡水路北道69号',1)
         insert into Students (StudentName,Gender,Birthday,Age,StudentIdNo,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('张慧鑫','女','1986-05-08',25,130226198605081528,'0006403822','022-66666666','河北衡水路北道69号',1)
         insert into Students (StudentName,Gender,Birthday,Age,StudentIdNo,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('李素云','女','1986-05-08',25,130227198605081528,'0006403823','022-66666666','河北衡水路北道69号',1)
         insert into Students (StudentName,Gender,Birthday,Age,StudentIdNo,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('赵小金','女','1986-05-08',25,130228198605081528,'0006403824','022-66666666','河北衡水路北道69号',1)
         insert into Students (StudentName,Gender,Birthday,Age,StudentIdNo,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('王浩宇','男','1986-05-08',25,130229198605081528,'0006403825','022-66666666','河北衡水路北道69号',1)
         insert into Students (StudentName,Gender,Birthday,Age,StudentIdNo,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('崔永鑫','女','1986-05-08',25,130222198605081528,'0006403826','022-66666666','河北衡水路北道69号',1)
         insert into Students (StudentName,Gender,Birthday,Age,StudentIdNo,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('包丽云','女','1986-05-08',25,130220198605081528,'0006403827','022-66666666','河北衡水路北道69号',1)
         
         insert into Students (StudentName,Gender,Birthday,Age,StudentIdNo,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('孙丽媛','女','1986-05-08',25,130228198605081530,'0006403854','022-66666666','河北衡水路北道69号',1)
         insert into Students (StudentName,Gender,Birthday,Age,StudentIdNo,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('郝志云','男','1986-05-08',25,130229198605081531,'0006403855','022-66666666','河北衡水路北道69号',1)
         insert into Students (StudentName,Gender,Birthday,Age,StudentIdNo,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('王保华','女','1986-05-08',25,130222198605081532,'0006403856','022-66666666','河北衡水路北道69号',1)
         insert into Students (StudentName,Gender,Birthday,Age,StudentIdNo,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('李丽颖','女','1986-05-08',25,130220198605081544,'0006403857','022-66666666','河北衡水路北道69号',1)
         
         
         
--插入成绩信息
insert into ScoreList (StudentId,CSharp,SQLServerDB)values(100000,60,78)
insert into ScoreList (StudentId,CSharp,SQLServerDB)values(100001,55,88)
insert into ScoreList (StudentId,CSharp,SQLServerDB)values(100002,90,58)
insert into ScoreList (StudentId,CSharp,SQLServerDB)values(100003,88,75)

insert into ScoreList (StudentId,CSharp,SQLServerDB)values(100004,62,88)
insert into ScoreList (StudentId,CSharp,SQLServerDB)values(100006,52,80)
insert into ScoreList (StudentId,CSharp,SQLServerDB)values(100007,91,66)
insert into ScoreList (StudentId,CSharp,SQLServerDB)values(100009,78,35)

insert into ScoreList (StudentId,CSharp,SQLServerDB)values(100000,60,78)
insert into ScoreList (StudentId,CSharp,SQLServerDB)values(100001,55,88)
insert into ScoreList (StudentId,CSharp,SQLServerDB)values(100002,90,58)
insert into ScoreList (StudentId,CSharp,SQLServerDB)values(100003,88,75)

insert into ScoreList (StudentId,CSharp,SQLServerDB)values(100004,62,88)
insert into ScoreList (StudentId,CSharp,SQLServerDB)values(100006,52,80)
insert into ScoreList (StudentId,CSharp,SQLServerDB)values(100007,91,66)
insert into ScoreList (StudentId,CSharp,SQLServerDB)values(100009,78,35)

--插入管理员信息
insert into Admins (LoginPwd,AdminName) values(123456,'王晓军')
insert into Admins (LoginPwd,AdminName) values(123456,'张明丽')



--树形菜单表
if exists(select * from sysobjects where name='MenuList')
drop table MenuList
create table MenuList
(
	 MenuId int identity(100,1) primary key,  
     MenuName varchar(50) ,--菜单名称,
	 MenuCode varchar(50),--菜单编码
     ParentId int --所属的类别（上一级的菜单编号）
)
go

--创建树形菜单表
if exists(select * from sysobjects where name='Menulist')
drop table MenuList
go
create table MenuList
(
	MenuId int identity(100,1) primary key,--菜单编号
	MenuName varchar(50) ,--菜单名称
	MenuCode varchar(50),--菜单编码(用来保存窗体的name)
	ParentId  int --父类编号(上一级菜单编号，递归必备)
)
go



--插入树形菜单数据

--插入一级菜单
insert into MenuList (MenuName,MenuCode,ParentId) values('系统管理','',0)  --100
insert into MenuList (MenuName,MenuCode,ParentId) values('学员管理','',0)  --101
insert into MenuList (MenuName,MenuCode,ParentId) values('成绩管理','',0)  --102
insert into MenuList (MenuName,MenuCode,ParentId) values('考勤管理','',0)  --103
insert into MenuList (MenuName,MenuCode,ParentId) values('系统帮助','',0)  --104
--插入二级菜单
insert into MenuList (MenuName,MenuCode,ParentId) values('密码修改','ModifyPwd',100)  

insert into MenuList (MenuName,MenuCode,ParentId) values('添加学员','AddStudent',101)  
insert into MenuList (MenuName,MenuCode,ParentId) values('批量导入学员','ImportData',101)  
insert into MenuList (MenuName,MenuCode,ParentId) values('学员信息管理','StudentManage',101) 

insert into MenuList (MenuName,MenuCode,ParentId) values('成绩查询与分析','ScoreManage',102)  
insert into MenuList (MenuName,MenuCode,ParentId) values('成绩快速查询','ScoreQuery',102)  

insert into MenuList (MenuName,MenuCode,ParentId) values('考勤打卡','Attendance',103)  
insert into MenuList (MenuName,MenuCode,ParentId) values('考勤查询','AttendanceQuery',103)  




--删除学员信息
--delete from Students 

--truncate table Students --删除全部数据以后，自动标识列重新编号

--显示学员信息和班级信息
select * from Students
select * from StudentClass
select * from ScoreList
select * from Admins
select * from Attendance
select * from MenuList






