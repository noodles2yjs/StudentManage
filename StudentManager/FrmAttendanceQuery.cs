using BLL;
using Common;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace StudentManager
{
    public partial class FrmAttendanceQuery : Form
    {
     
        public FrmAttendanceQuery()
        {
            InitializeComponent();
            this.dgvStudentList.AutoGenerateColumns= false;
            new DataGridViewStyle().DgvStyle3(this.dgvStudentList);

        }
        #region 属性和字段
        private AttendanceManage attendanceManage = new AttendanceManage();
        private List<Student> studentList = new List<Student>();
        #endregion
        private void btnQuery_Click(object sender, EventArgs e)
        {
            ShowStat();
            DateTime dt1 = Convert.ToDateTime(dtpTime.Text);
            DateTime dt2  =dt1.AddDays(1);
            studentList = attendanceManage.GetAttendanceStudentList(dt1,dt2,this.txtName.Text.Trim());
            if (studentList.Count >0 )
            {
                this.dgvStudentList.DataSource = null;
                this.dgvStudentList.DataSource = studentList;
            }
            else
            {

                this.dgvStudentList.DataSource=null;
            }
        }

        private void ShowStat()
        {
            try
            {
                // 应到总人数
                this.lblCount.Text = attendanceManage.GetAllStudentCount();
                // 显示出勤人数
                this.lblReal.Text = attendanceManage.GetAttendaceStudentCount(Convert.ToDateTime(this.dtpTime.Text), false);

                //显示缺勤人数

                this.lblAbsenceCount.Text = (Convert.ToInt32(this.lblCount.Text) - Convert.ToInt32(this.lblReal.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示");
            }
        }
        //添加行号
        private void dgvStudentList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
          //  Common.DataGridViewStyle.DgvRowPostPaint(this.dgvStudentList, e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
