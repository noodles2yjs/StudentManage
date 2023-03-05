using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Models;
using BLL;

namespace StudentManager
{
    public partial class FrmEditStudent : Form
    {
        public FrmEditStudent()
        {
            InitializeComponent();
            
        }

        public FrmEditStudent(Student student) : this()
        {
            this.Student = student;

            // 初始化班级下拉框
            this.cboClassName.DataSource = StudentClassManage.GetAllClass();
            this.cboClassName.DisplayMember = "ClassName";
            this.cboClassName.ValueMember= "ClassId";

            // 显示学生信息

            this.txtStudentName.Text = student.StudentName;
            this.txtStudentIdNo.Text = student.StudentIdNo;
            this.txtStudentId.Text = student.StudentId.ToString();
            this.txtStudentId.Enabled= false;
            this.txtPhoneNumber.Text = student.PhoneNumber;
            this.txtAddress.Text = student.StudentAddress;
            this.txtCardNo.Text = student.CardNo;

            if (student.Gender == "男") this.rdoMale.Checked = true;
            else this.rdoFemale.Checked = true;

            //if (student.Gender == "男") this.rdoMale.Checked = true;
            //else this.rdoFemale.Checked = true;
            this.cboClassName.Text= student.ClassName;

            this.dtpBirthday.Text = student.Birthday.ToShortDateString();
            // 显示照片

            this.pbStu.Image = student.StuImage.Length == 0 ? Image.FromFile("default.png") : (Image)new SerializeObjectToString().DeserializeObject(student.StuImage);

        }

        #region 属性和字段
        private Student Student =new Student();

        private StudentClassManage  StudentClassManage= new StudentClassManage();

        private StudentManage studentManage = new StudentManage();
        #endregion

        //提交修改
        private void btnModify_Click(object sender, EventArgs e)
        {
            
            #region  数据验证
            if (this.txtStudentName.Text.Trim().Length == 0)
            {
                MessageBox.Show("学生姓名不能为空!", "提示信息");
                this.txtStudentName.Focus();
                return;

            }

            if (this.txtAddress.Text.Trim().Length == 0)
            {
                MessageBox.Show("地址不能为空!", "提示信息");
                this.txtAddress.Focus();
                return;
            }

            if (this.txtCardNo.Text.Trim().Length == 0)
            {
                MessageBox.Show("考勤卡号不能为空!", "提示信息");
                this.txtCardNo.Focus();
                return;
            }

            if (this.txtPhoneNumber.Text.Trim().Length == 0)
            {
                MessageBox.Show("电话不能为空!", "提示信息");
                this.txtPhoneNumber.Focus();
                return;
            }
            if (this.txtStudentIdNo.Text.Trim().Length == 0)
            {
                MessageBox.Show("身份证号不能为空!", "提示信息");
                this.txtStudentIdNo.Focus();
                return;
            }

            if (this.studentManage.IsIDExisted(this.txtStudentIdNo.Text.Trim(),this.txtStudentId.Text.Trim()))
            {
                MessageBox.Show("身份证号重复!", "提示信息");
                this.txtStudentIdNo.Focus();
                return;
            }
            if (!DataValidate.IsIdentityCard(this.txtStudentIdNo.Text.Trim()))
            {
                MessageBox.Show("身份证号不合法!", "提示信息");
                this.txtStudentIdNo.Focus();
                return;
            }

            // 验证身份证号和出生日期是否吻合
            string month = string.Empty;
            string day = string.Empty;
            if (Convert.ToDateTime(this.dtpBirthday.Text).Month < 10)
            {
                month = "0" + Convert.ToDateTime(this.dtpBirthday.Text).Month;
            }
            else
            {
                month = Convert.ToDateTime(this.dtpBirthday.Text).Month.ToString();
            }

            if (Convert.ToDateTime(this.dtpBirthday.Text).Day < 10)
            {
                day = "0" + Convert.ToDateTime(this.dtpBirthday.Text).Day;
            }
            else
            {
                day= Convert.ToDateTime(this.dtpBirthday.Text).Day.ToString();
            }

            string birthday = Convert.ToDateTime(this.dtpBirthday.Text).Year + month + day;

            if (!this.txtStudentIdNo.Text.Trim().Contains(birthday))
            {
                MessageBox.Show("身份证号和出生日期不匹配!", "提示信息");
                this.txtStudentIdNo.Focus();
                this.txtStudentIdNo.SelectAll();
                return;
            }
            // 验证出生日期 // 年龄不能小于18

            int age = DateTime.Now.Year - Convert.ToDateTime(this.dtpBirthday.Text).Year;
            if (age < 18)
            {
                MessageBox.Show("学生年龄不能小于18岁!", "提示信息");
                return;
            }

            if (this.cboClassName.SelectedIndex == -1)
            {
                MessageBox.Show("请选择班级!", "提示信息");
                return;
            }

            // 验证性别

            if (!this.rdoFemale.Checked && !this.rdoMale.Checked)
            {
                MessageBox.Show("请选择学生性别!", "提示信息");
                return;
            }
            #endregion

            // 封装到对象
            Student student = new Student
            {
                StudentAddress = this.txtAddress.Text.Trim().Length == 0 ? "地址不详" : this.txtAddress.Text.Trim(),
                Age = age,
                Birthday = Convert.ToDateTime(this.dtpBirthday.Text),
                CardNo = this.txtCardNo.Text.Trim(),
                ClassId = Convert.ToInt32(this.cboClassName.SelectedValue),
                ClassName = this.cboClassName.Text.Trim(),
                Gender = this.rdoMale.Checked ? "男" : "女",
                PhoneNumber = this.txtPhoneNumber.Text.Trim(),
                StudentId = Convert.ToInt32(this.txtStudentId.Text.Trim()),
                StudentIdNo = this.txtStudentIdNo.Text.Trim(),
                StudentName = this.txtStudentName.Text.Trim(),
                StuImage = this.pbStu.Image == null ? "" : new SerializeObjectToString().SerializeObject(this.pbStu.Image),

            };


            // 修改对象

            try
            {
                if (studentManage.ModifyStudent(student) ==1)
                {
                    MessageBox.Show("学员信息修改成功!","提示");
                    this.DialogResult= DialogResult.OK;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("修改对象出错: "+ex.Message,"提示信息");
            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //选择照片
        private void btnChoseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.pbStu.Image = Image.FromFile(openFileDialog.FileName);
            }

        }
    }
}