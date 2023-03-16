using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using BLL;
using Models;
using Common;
using System.Linq;

namespace StudentManager
{
    public partial class FrmStudentManage : Form
    {

        public FrmStudentManage()
        {
            InitializeComponent();
            this.dgvStudentList.AutoGenerateColumns= false; //����ʾδ�󶨵�����
            // ��ʼ���༶������
            List<StudentClass> studentClasses = this.studentClassManage.GetAllClass();
            this.cboClass.DataSource = studentClasses;
            // �������������ʾ�ı�
            this.cboClass.DisplayMember = "ClassName";
            // �������������ʾ�ı���Ӧ��Value
            this.cboClass.ValueMember = "ClassId";
            // ����dgv����ʽ
            new DataGridViewStyle().DgvStyle1(this.dgvStudentList);

            //this.studentList = studentManage.GetAllStudents();
            //if (this.studentList.Count != 0)
            //{
            //    // this.dgvStudentList = null;
            //    this.dgvStudentList.DataSource = this.studentList;
            //    this.btnEidt.Enabled = true;

            //}
            //else
            //{

            //    this.btnEidt.Enabled = false;
            //}
            studentList = studentManage.GetAllStudents();

            this.dgvStudentList.DataSource = studentList;

        }

        #region ���Ժ��ֶ�

        private StudentManage studentManage = new StudentManage();
        private StudentClassManage studentClassManage = new StudentClassManage();
        private List<Student> studentList= new List<Student>();

        #endregion
        //���հ༶��ѯ
        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (this.cboClass.SelectedIndex == -1)
            {
                MessageBox.Show("��ѡ��༶","��ʾ");
                return;
            }
            // ִ�в�ѯ��������
            try
            {
                studentList = studentManage.GetStudentsByClassName(this.cboClass.Text);
                this.dgvStudentList.DataSource = null;
                if (studentList.Count>0)
                {
                    this.dgvStudentList.DataSource = studentList;
                  

                    //�ñ��⳹�׾��У���������ť��Ӱ��
                 
                    foreach (DataGridViewColumn item in this.dgvStudentList.Columns)
                    {
                        item.SortMode = DataGridViewColumnSortMode.NotSortable;
                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("��ѯ����:"+ex.Message,"��ʾ");
            }

        }
        //����ѧ�Ų�ѯ
        private void btnQueryById_Click(object sender, EventArgs e)
        {
            // ������֤
            string studenId = this.txtStudentId.Text.Trim();
            if (this.txtStudentId.Text.Trim().Length==0)
            {
                MessageBox.Show("������ѧ��","��ʾ");
                this.txtStudentId.Focus();
                return;

            }

            if (!DataValidate.IsInteger(studenId))
            {
                MessageBox.Show("ѧ�ű���Ϊ����", "��ʾ");
                this.txtStudentId.Focus();
                return;
            }

            Student student = this.studentManage.GetStudnetByStudentyId(studenId);
            if (student == null)
            {
                MessageBox.Show("ѧԱ��Ϣ������", "��ʾ");
                this.txtStudentId.Focus();
                return;
            }
            else
            {
                new FrmStudentInfo(student).Show();
            }


        }
        private void txtStudentId_KeyDown(object sender, KeyEventArgs e)
        {
         
        }
        //˫��ѡ�е�ѧԱ������ʾ��ϸ��Ϣ
        private void dgvStudentList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvStudentList.CurrentRow != null)
            {
                this.txtStudentId.Text = this.dgvStudentList.CurrentRow.Cells["StudentId"].Value.ToString();

                btnQueryById_Click(null,null);
            }
        }
        //�޸�ѧԱ����
        private void btnEidt_Click(object sender, EventArgs e)
        {
            if (this.dgvStudentList.RowCount ==0)
            {
                MessageBox.Show("û���κ���Ҫ�޸ĵ�ѧԱ��Ϣ","��ʾ��Ϣ");
                return;
            }

            if (this.dgvStudentList.CurrentRow == null)
            {
                MessageBox.Show("��ѡ����Ҫ�޸ĵ�ѧԱ��Ϣ", "��ʾ��Ϣ");
                return;
            }

            // ��ȡѧ��
            string studentId = this.dgvStudentList.CurrentRow.Cells["StudentId"].Value.ToString().Trim();

            Student student = studentManage.GetStudnetByStudentyId(studentId);

            FrmEditStudent frmEditStudent = new FrmEditStudent(student);

            DialogResult dialogResult = frmEditStudent.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                //btnQuery_Click(null,null); // �˴�������Linq�Ľ�

               Student  oldStudent = studentList.SingleOrDefault(s =>s.StudentId== Convert.ToInt32(studentId));
              Student  NewStudent = studentManage.GetStudnetByStudentyId(studentId);

                oldStudent.StudentId = NewStudent.StudentId;
                oldStudent.StudentName = NewStudent.StudentName;
                oldStudent.PhoneNumber= NewStudent.PhoneNumber;
                oldStudent.Birthday = NewStudent.Birthday;
                oldStudent.ClassName = NewStudent.ClassName;
                oldStudent.Gender= NewStudent.Gender;
                oldStudent.StudentIdNo= NewStudent.StudentIdNo;

                this.dgvStudentList.Refresh();

            }

        }
        //ɾ��ѧԱ����
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (this.dgvStudentList.Rows.Count == 0 || this.dgvStudentList.CurrentRow == null) return;
            string stuId = this.dgvStudentList.CurrentRow.Cells["StudentId"].Value.ToString();
            string stuName = this.dgvStudentList.CurrentRow.Cells["StudentName"].Value.ToString();

            DialogResult dialogResult = MessageBox.Show($"�Ƿ�Ҫɾ��[{stuName}]","��ʾ",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Cancel)
            {
                return;
            }
            try
            {
                studentManage.DeleteStudent(stuId);
                MessageBox.Show("ɾ���ɹ�!", "��ʾ");
            }
            catch (Exception ex)
            {

                MessageBox.Show("ɾ��ʧ��!"+ex.Message,"��ʾ");
                return;
            }

            // ɾ�����ˢ��
            this.studentList.RemoveAll(s => s.StudentId == Convert.ToInt32(stuId));
            this.dgvStudentList.DataSource = null;
            if (this.studentList.Count>0)
            {
                this.dgvStudentList.DataSource = this.studentList;
            }



        }
        //��������
        private void btnNameDESC_Click(object sender, EventArgs e)
        {
            // ע��:����͸��Ŀ���ʹ��Refresh ����,����ɾ��������

            if (this.dgvStudentList.RowCount == 0) return;
            studentList.Sort(new StudentDescSortByName());
            this.dgvStudentList.Refresh();

        }
        //ѧ�Ž���
        private void btnStuIdDESC_Click(object sender, EventArgs e)
        {

            if (this.dgvStudentList.RowCount == 0) return;
            studentList.Sort(new StudentDescSortByStudentId());
            this.dgvStudentList.Refresh();
        }
        //����к�
        private void dgvStudentList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
        
        }
        //��ӡ��ǰѧԱ��Ϣ
        private void btnPrint_Click(object sender, EventArgs e)
        {
          
        }

        //�ر�
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //������Excel
        private void btnExport_Click(object sender, EventArgs e)
        {

        }

        #region ʵ������
        class StudentDescSortByName : IComparer<Student>
        {
            public int Compare(Student x, Student y)
            {
                return y.StudentName.CompareTo(x.StudentName);
            }
        }

        class StudentDescSortByStudentId : IComparer<Student>
        {
            public int Compare(Student x, Student y)
            {
                return y.StudentId.CompareTo(x.StudentId);
            }
        }

        #endregion

        private void tsmiModifyStu_Click(object sender, EventArgs e)
        {
            btnEidt_Click(null, null);
        }

        private void tsmidDeleteStu_Click(object sender, EventArgs e)
        {
            btnDel_Click(null,null);
        }
    }


}