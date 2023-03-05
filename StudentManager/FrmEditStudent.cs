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

            // ��ʼ���༶������
            this.cboClassName.DataSource = StudentClassManage.GetAllClass();
            this.cboClassName.DisplayMember = "ClassName";
            this.cboClassName.ValueMember= "ClassId";

            // ��ʾѧ����Ϣ

            this.txtStudentName.Text = student.StudentName;
            this.txtStudentIdNo.Text = student.StudentIdNo;
            this.txtStudentId.Text = student.StudentId.ToString();
            this.txtStudentId.Enabled= false;
            this.txtPhoneNumber.Text = student.PhoneNumber;
            this.txtAddress.Text = student.StudentAddress;
            this.txtCardNo.Text = student.CardNo;

            if (student.Gender == "��") this.rdoMale.Checked = true;
            else this.rdoFemale.Checked = true;

            //if (student.Gender == "��") this.rdoMale.Checked = true;
            //else this.rdoFemale.Checked = true;
            this.cboClassName.Text= student.ClassName;

            this.dtpBirthday.Text = student.Birthday.ToShortDateString();
            // ��ʾ��Ƭ

            this.pbStu.Image = student.StuImage.Length == 0 ? Image.FromFile("default.png") : (Image)new SerializeObjectToString().DeserializeObject(student.StuImage);

        }

        #region ���Ժ��ֶ�
        private Student Student =new Student();

        private StudentClassManage  StudentClassManage= new StudentClassManage();

        private StudentManage studentManage = new StudentManage();
        #endregion

        //�ύ�޸�
        private void btnModify_Click(object sender, EventArgs e)
        {
            
            #region  ������֤
            if (this.txtStudentName.Text.Trim().Length == 0)
            {
                MessageBox.Show("ѧ����������Ϊ��!", "��ʾ��Ϣ");
                this.txtStudentName.Focus();
                return;

            }

            if (this.txtAddress.Text.Trim().Length == 0)
            {
                MessageBox.Show("��ַ����Ϊ��!", "��ʾ��Ϣ");
                this.txtAddress.Focus();
                return;
            }

            if (this.txtCardNo.Text.Trim().Length == 0)
            {
                MessageBox.Show("���ڿ��Ų���Ϊ��!", "��ʾ��Ϣ");
                this.txtCardNo.Focus();
                return;
            }

            if (this.txtPhoneNumber.Text.Trim().Length == 0)
            {
                MessageBox.Show("�绰����Ϊ��!", "��ʾ��Ϣ");
                this.txtPhoneNumber.Focus();
                return;
            }
            if (this.txtStudentIdNo.Text.Trim().Length == 0)
            {
                MessageBox.Show("���֤�Ų���Ϊ��!", "��ʾ��Ϣ");
                this.txtStudentIdNo.Focus();
                return;
            }

            if (this.studentManage.IsIDExisted(this.txtStudentIdNo.Text.Trim(),this.txtStudentId.Text.Trim()))
            {
                MessageBox.Show("���֤���ظ�!", "��ʾ��Ϣ");
                this.txtStudentIdNo.Focus();
                return;
            }
            if (!DataValidate.IsIdentityCard(this.txtStudentIdNo.Text.Trim()))
            {
                MessageBox.Show("���֤�Ų��Ϸ�!", "��ʾ��Ϣ");
                this.txtStudentIdNo.Focus();
                return;
            }

            // ��֤���֤�źͳ��������Ƿ��Ǻ�
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
                MessageBox.Show("���֤�źͳ������ڲ�ƥ��!", "��ʾ��Ϣ");
                this.txtStudentIdNo.Focus();
                this.txtStudentIdNo.SelectAll();
                return;
            }
            // ��֤�������� // ���䲻��С��18

            int age = DateTime.Now.Year - Convert.ToDateTime(this.dtpBirthday.Text).Year;
            if (age < 18)
            {
                MessageBox.Show("ѧ�����䲻��С��18��!", "��ʾ��Ϣ");
                return;
            }

            if (this.cboClassName.SelectedIndex == -1)
            {
                MessageBox.Show("��ѡ��༶!", "��ʾ��Ϣ");
                return;
            }

            // ��֤�Ա�

            if (!this.rdoFemale.Checked && !this.rdoMale.Checked)
            {
                MessageBox.Show("��ѡ��ѧ���Ա�!", "��ʾ��Ϣ");
                return;
            }
            #endregion

            // ��װ������
            Student student = new Student
            {
                StudentAddress = this.txtAddress.Text.Trim().Length == 0 ? "��ַ����" : this.txtAddress.Text.Trim(),
                Age = age,
                Birthday = Convert.ToDateTime(this.dtpBirthday.Text),
                CardNo = this.txtCardNo.Text.Trim(),
                ClassId = Convert.ToInt32(this.cboClassName.SelectedValue),
                ClassName = this.cboClassName.Text.Trim(),
                Gender = this.rdoMale.Checked ? "��" : "Ů",
                PhoneNumber = this.txtPhoneNumber.Text.Trim(),
                StudentId = Convert.ToInt32(this.txtStudentId.Text.Trim()),
                StudentIdNo = this.txtStudentIdNo.Text.Trim(),
                StudentName = this.txtStudentName.Text.Trim(),
                StuImage = this.pbStu.Image == null ? "" : new SerializeObjectToString().SerializeObject(this.pbStu.Image),

            };


            // �޸Ķ���

            try
            {
                if (studentManage.ModifyStudent(student) ==1)
                {
                    MessageBox.Show("ѧԱ��Ϣ�޸ĳɹ�!","��ʾ");
                    this.DialogResult= DialogResult.OK;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("�޸Ķ������: "+ex.Message,"��ʾ��Ϣ");
            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //ѡ����Ƭ
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