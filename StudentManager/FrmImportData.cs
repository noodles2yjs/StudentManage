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
    public partial class FrmImportData : Form
    {


        public FrmImportData()
        {
            InitializeComponent();
        }
        private void btnChoseExcel_Click(object sender, EventArgs e)
        {

        }
        private void dgvStudentList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // Common.DataGridViewStyle.DgvRowPostPaint(this.dgvStudentList, e);
        }
        //保存到数据库
        private void btnSaveToDB_Click(object sender, EventArgs e)
        {

        }
    }
}

