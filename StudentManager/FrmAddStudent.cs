using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Models;
using DAL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using BLL;
using Common;

namespace StudentManager
{
    public partial class FrmAddStudent : Form
    {
        #region 属性字段
        private StudentClassManage studentClassManage = new StudentClassManage();
        //  private StudentClassService _StudentClassService;
        // private StudentService _StudentService ;

        private StudentManage studentManage = new StudentManage();

        private List<Student> StudentsList = new List<Student>();
        private DataSet dataSet= null;
        #endregion
        public FrmAddStudent()
        {
            InitializeComponent();
            this.dgvStudentList.AutoGenerateColumns= false;
            // 初始化班级下拉框
            List<StudentClass> studentClasses = this.studentClassManage.GetAllClass();
            this.cboClassName.DataSource = studentClasses;
            // 设置下拉框的显示文本
            this.cboClassName.DisplayMember = "ClassName";
            // 设置下拉框的显示文本对应的Value
            this.cboClassName.ValueMember = "ClassId";

            // 设置窗体接收键盘按下事件
            this.KeyPreview = true; 


        }
        //添加新学员
        private void btnAdd_Click(object sender, EventArgs e)
        {

            #region 数据验证
            if (txtStudentName.Text.Trim().Length == 0)
            {
                MessageBox.Show("学生姓名不能为空!", "提示");
                txtStudentName.Focus();
                return;
            }
            // 验证性别

            if (!this.rdoFemale.Checked && !this.rdoMale.Checked)
            {
                MessageBox.Show("请选择学生性别!","提示信息");
                return;
            }

            // 不需要验证出生日期,因为会在后面的 验证身份证号与出生日期是否匹配中 进行验证

            // 验证所在班级
            if (cboClassName.SelectedIndex == -1)
            {
                MessageBox.Show("请选择班级!","提示信息");
                return;
            }

            // 验证年龄
            int age = DateTime.Now.Year - Convert.ToDateTime(dtpBirthday.Text).Year;
            if (!(age <= 35 && age >= 18))
            {
                MessageBox.Show("年龄必须在28-35岁之间");
                return;
            }

            // 验证身份证号是否符合要求
            if (!DataValidate.IsIdentityCard(txtStudentIdNo.Text.Trim()))
            {
                MessageBox.Show("身份证号不符合要求!", "提示信息");
                txtStudentIdNo.Focus();
                return;
            }

            // 验证身份证号和出生日期是否匹配

            if (!txtStudentIdNo.Text.Trim().Contains(dtpBirthday.Value.ToString("yyyyMMdd")))
            {
                MessageBox.Show("身份证号和出生日期不匹配","提示信息");
                txtStudentIdNo.Focus();
                txtStudentIdNo.SelectAll();
                return;
            }


            // 调用相应数据库访问类验证

            // 验证身份证号是否重复

            if (this.studentManage.IsIDExisted(txtStudentIdNo.Text.Trim()))
            {
                MessageBox.Show("身份证号已经存在!","提示信息");
                txtStudentIdNo.Focus();
                txtStudentIdNo.SelectAll();
                return;
            }

            // 验证考勤卡号 

            if (this.studentManage.IsCardIdExisted(txtCardNo.Text.Trim()))
            {
                MessageBox.Show("考勤卡号已经存在!", "提示信息");
                txtCardNo.Focus();
                txtCardNo.SelectAll();
                return;
            }

            #endregion

            #region 封装学生对象
            Student student = new Student
            {
                StudentName = this.txtStudentName.Text.Trim(),
                Age = DateTime.Now.Year - Convert.ToDateTime(this.dtpBirthday.Text).Year,
                StudentAddress = this.txtAddress.Text.Trim(),
                StudentIdNo = this.txtStudentIdNo.Text.Trim(),
                Gender = this.rdoFemale.Checked ? "女" : "男",
                Birthday = Convert.ToDateTime(this.dtpBirthday.Text.Trim()),
                CardNo = this.txtCardNo.Text.Trim(),
                ClassId = Convert.ToInt32(this.cboClassName.SelectedValue),
                PhoneNumber = this.txtPhoneNumber.Text.Trim(),
                StuImage = this.pbStu.Image != null ? new SerializeObjectToString().SerializeObject(this.pbStu.Image) : "",


            };
            #endregion

            #region 调用后台数据访问方法添加对象
            try
            {
                int ret = this.studentManage.AddStudent(student);
                if (ret > 1)
                {
                    // 同步显示添加的学员
                    student.StudentId = ret;
                    this.StudentsList.Add(student);
                    this.dgvStudentList.DataSource = null;// 不知道为什么加这句话
                    this.dgvStudentList.DataSource = this.StudentsList;
                    // 询问是否继续添加
                    DialogResult dialogResult
                        = MessageBox.Show("新学员添加成功! 是否继续添加?", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        //  清除用户输入信息
                        foreach (var control in this.gbstuinfo.Controls)
                        {
                            if (control is System.Windows.Forms.TextBox t)
                            {
                                t.Text = "";
                            }
                            this.cboClassName.SelectedIndex = -1;
                            this.rdoFemale.Checked = false;
                            this.rdoMale.Checked = false;
                            this.txtStudentName.Focus();
                            this.pbStu.Image = null;
                        }
                    }
                    else
                    {
                        this.Close();
                    }


                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            #endregion



        }
        //关闭窗体
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmAddStudent_KeyDown(object sender, KeyEventArgs e)
        {
       

        }
        //选择新照片
        private void btnChoseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.pbStu.Image = Image.FromFile(openFileDialog.FileName);
            }
           
        }
        //启动摄像头
        private void btnStartVideo_Click(object sender, EventArgs e)
        {
         
        }
        //拍照
        private void btnTake_Click(object sender, EventArgs e)
        {
        
        }
        //清除照片
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.pbStu.Image = null;
        }

        private void btn_query_Click(object sender, EventArgs e)
        {

          dataSet=  studentManage.QueryAllStudents();
            this.dgvStudentList.DataSource = null;
            this.dgvStudentList.DataSource = dataSet.Tables[0];

        }

        private void dgvStudentList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewStyle.DgvRowPostPaint(dgvStudentList, e);
        }
    }
}