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
        #region �����ֶ�
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
            // ��ʼ���༶������
            List<StudentClass> studentClasses = this.studentClassManage.GetAllClass();
            this.cboClassName.DataSource = studentClasses;
            // �������������ʾ�ı�
            this.cboClassName.DisplayMember = "ClassName";
            // �������������ʾ�ı���Ӧ��Value
            this.cboClassName.ValueMember = "ClassId";

            // ���ô�����ռ��̰����¼�
            this.KeyPreview = true; 


        }
        //�����ѧԱ
        private void btnAdd_Click(object sender, EventArgs e)
        {

            #region ������֤
            if (txtStudentName.Text.Trim().Length == 0)
            {
                MessageBox.Show("ѧ����������Ϊ��!", "��ʾ");
                txtStudentName.Focus();
                return;
            }
            // ��֤�Ա�

            if (!this.rdoFemale.Checked && !this.rdoMale.Checked)
            {
                MessageBox.Show("��ѡ��ѧ���Ա�!","��ʾ��Ϣ");
                return;
            }

            // ����Ҫ��֤��������,��Ϊ���ں���� ��֤���֤������������Ƿ�ƥ���� ������֤

            // ��֤���ڰ༶
            if (cboClassName.SelectedIndex == -1)
            {
                MessageBox.Show("��ѡ��༶!","��ʾ��Ϣ");
                return;
            }

            // ��֤����
            int age = DateTime.Now.Year - Convert.ToDateTime(dtpBirthday.Text).Year;
            if (!(age <= 35 && age >= 18))
            {
                MessageBox.Show("���������28-35��֮��");
                return;
            }

            // ��֤���֤���Ƿ����Ҫ��
            if (!DataValidate.IsIdentityCard(txtStudentIdNo.Text.Trim()))
            {
                MessageBox.Show("���֤�Ų�����Ҫ��!", "��ʾ��Ϣ");
                txtStudentIdNo.Focus();
                return;
            }

            // ��֤���֤�źͳ��������Ƿ�ƥ��

            if (!txtStudentIdNo.Text.Trim().Contains(dtpBirthday.Value.ToString("yyyyMMdd")))
            {
                MessageBox.Show("���֤�źͳ������ڲ�ƥ��","��ʾ��Ϣ");
                txtStudentIdNo.Focus();
                txtStudentIdNo.SelectAll();
                return;
            }


            // ������Ӧ���ݿ��������֤

            // ��֤���֤���Ƿ��ظ�

            if (this.studentManage.IsIDExisted(txtStudentIdNo.Text.Trim()))
            {
                MessageBox.Show("���֤���Ѿ�����!","��ʾ��Ϣ");
                txtStudentIdNo.Focus();
                txtStudentIdNo.SelectAll();
                return;
            }

            // ��֤���ڿ��� 

            if (this.studentManage.IsCardIdExisted(txtCardNo.Text.Trim()))
            {
                MessageBox.Show("���ڿ����Ѿ�����!", "��ʾ��Ϣ");
                txtCardNo.Focus();
                txtCardNo.SelectAll();
                return;
            }

            #endregion

            #region ��װѧ������
            Student student = new Student
            {
                StudentName = this.txtStudentName.Text.Trim(),
                Age = DateTime.Now.Year - Convert.ToDateTime(this.dtpBirthday.Text).Year,
                StudentAddress = this.txtAddress.Text.Trim(),
                StudentIdNo = this.txtStudentIdNo.Text.Trim(),
                Gender = this.rdoFemale.Checked ? "Ů" : "��",
                Birthday = Convert.ToDateTime(this.dtpBirthday.Text.Trim()),
                CardNo = this.txtCardNo.Text.Trim(),
                ClassId = Convert.ToInt32(this.cboClassName.SelectedValue),
                PhoneNumber = this.txtPhoneNumber.Text.Trim(),
                StuImage = this.pbStu.Image != null ? new SerializeObjectToString().SerializeObject(this.pbStu.Image) : "",


            };
            #endregion

            #region ���ú�̨���ݷ��ʷ�����Ӷ���
            try
            {
                int ret = this.studentManage.AddStudent(student);
                if (ret > 1)
                {
                    // ͬ����ʾ��ӵ�ѧԱ
                    student.StudentId = ret;
                    this.StudentsList.Add(student);
                    this.dgvStudentList.DataSource = null;// ��֪��Ϊʲô����仰
                    this.dgvStudentList.DataSource = this.StudentsList;
                    // ѯ���Ƿ�������
                    DialogResult dialogResult
                        = MessageBox.Show("��ѧԱ��ӳɹ�! �Ƿ�������?", "��ʾ��Ϣ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        //  ����û�������Ϣ
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
        //�رմ���
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmAddStudent_KeyDown(object sender, KeyEventArgs e)
        {
       

        }
        //ѡ������Ƭ
        private void btnChoseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.pbStu.Image = Image.FromFile(openFileDialog.FileName);
            }
           
        }
        //��������ͷ
        private void btnStartVideo_Click(object sender, EventArgs e)
        {
         
        }
        //����
        private void btnTake_Click(object sender, EventArgs e)
        {
        
        }
        //�����Ƭ
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