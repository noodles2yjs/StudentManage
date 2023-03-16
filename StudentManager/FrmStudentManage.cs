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
            this.dgvStudentList.AutoGenerateColumns= false; //不显示未绑定的属性
            // 初始化班级下拉框
            List<StudentClass> studentClasses = this.studentClassManage.GetAllClass();
            this.cboClass.DataSource = studentClasses;
            // 设置下拉框的显示文本
            this.cboClass.DisplayMember = "ClassName";
            // 设置下拉框的显示文本对应的Value
            this.cboClass.ValueMember = "ClassId";
            // 设置dgv的样式
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

        #region 属性和字段

        private StudentManage studentManage = new StudentManage();
        private StudentClassManage studentClassManage = new StudentClassManage();
        private List<Student> studentList= new List<Student>();

        #endregion
        //按照班级查询
        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (this.cboClass.SelectedIndex == -1)
            {
                MessageBox.Show("请选择班级","提示");
                return;
            }
            // 执行查询并绑定数据
            try
            {
                studentList = studentManage.GetStudentsByClassName(this.cboClass.Text);
                this.dgvStudentList.DataSource = null;
                if (studentList.Count>0)
                {
                    this.dgvStudentList.DataSource = studentList;
                  

                    //让标题彻底居中，消除排序按钮的影响
                 
                    foreach (DataGridViewColumn item in this.dgvStudentList.Columns)
                    {
                        item.SortMode = DataGridViewColumnSortMode.NotSortable;
                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("查询出错:"+ex.Message,"提示");
            }

        }
        //根据学号查询
        private void btnQueryById_Click(object sender, EventArgs e)
        {
            // 数据验证
            string studenId = this.txtStudentId.Text.Trim();
            if (this.txtStudentId.Text.Trim().Length==0)
            {
                MessageBox.Show("请输入学号","提示");
                this.txtStudentId.Focus();
                return;

            }

            if (!DataValidate.IsInteger(studenId))
            {
                MessageBox.Show("学号必须为整数", "提示");
                this.txtStudentId.Focus();
                return;
            }

            Student student = this.studentManage.GetStudnetByStudentyId(studenId);
            if (student == null)
            {
                MessageBox.Show("学员信息不存在", "提示");
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
        //双击选中的学员对象并显示详细信息
        private void dgvStudentList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvStudentList.CurrentRow != null)
            {
                this.txtStudentId.Text = this.dgvStudentList.CurrentRow.Cells["StudentId"].Value.ToString();

                btnQueryById_Click(null,null);
            }
        }
        //修改学员对象
        private void btnEidt_Click(object sender, EventArgs e)
        {
            if (this.dgvStudentList.RowCount ==0)
            {
                MessageBox.Show("没有任何需要修改的学员信息","提示信息");
                return;
            }

            if (this.dgvStudentList.CurrentRow == null)
            {
                MessageBox.Show("请选中需要修改的学员信息", "提示信息");
                return;
            }

            // 获取学号
            string studentId = this.dgvStudentList.CurrentRow.Cells["StudentId"].Value.ToString().Trim();

            Student student = studentManage.GetStudnetByStudentyId(studentId);

            FrmEditStudent frmEditStudent = new FrmEditStudent(student);

            DialogResult dialogResult = frmEditStudent.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                //btnQuery_Click(null,null); // 此处可以用Linq改进

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
        //删除学员对象
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (this.dgvStudentList.Rows.Count == 0 || this.dgvStudentList.CurrentRow == null) return;
            string stuId = this.dgvStudentList.CurrentRow.Cells["StudentId"].Value.ToString();
            string stuName = this.dgvStudentList.CurrentRow.Cells["StudentName"].Value.ToString();

            DialogResult dialogResult = MessageBox.Show($"是否要删除[{stuName}]","提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Cancel)
            {
                return;
            }
            try
            {
                studentManage.DeleteStudent(stuId);
                MessageBox.Show("删除成功!", "提示");
            }
            catch (Exception ex)
            {

                MessageBox.Show("删除失败!"+ex.Message,"提示");
                return;
            }

            // 删除后的刷新
            this.studentList.RemoveAll(s => s.StudentId == Convert.ToInt32(stuId));
            this.dgvStudentList.DataSource = null;
            if (this.studentList.Count>0)
            {
                this.dgvStudentList.DataSource = this.studentList;
            }



        }
        //姓名降序
        private void btnNameDESC_Click(object sender, EventArgs e)
        {
            // 注意:排序和更改可是使用Refresh 方法,增加删除不可以

            if (this.dgvStudentList.RowCount == 0) return;
            studentList.Sort(new StudentDescSortByName());
            this.dgvStudentList.Refresh();

        }
        //学号降序
        private void btnStuIdDESC_Click(object sender, EventArgs e)
        {

            if (this.dgvStudentList.RowCount == 0) return;
            studentList.Sort(new StudentDescSortByStudentId());
            this.dgvStudentList.Refresh();
        }
        //添加行号
        private void dgvStudentList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
        
        }
        //打印当前学员信息
        private void btnPrint_Click(object sender, EventArgs e)
        {
          
        }

        //关闭
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //导出到Excel
        private void btnExport_Click(object sender, EventArgs e)
        {

        }

        #region 实现排序
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