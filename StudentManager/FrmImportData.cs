
using DAL.Helper;
using Models;
using Models.Ext;
using StudentManager.NPOI;
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
            this.dgvStudentList.AutoGenerateColumns = false;

            // 让标题栏彻底居中

            foreach (DataGridViewColumn item in this.dgvStudentList.Columns)
            {
                item.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        #region 属性和字段
        private List<StudentToExcel> studentList = new List<StudentToExcel>();
        #endregion
        /// <summary>
        /// 从Excel中导入数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChoseExcel_Click(object sender, EventArgs e)
        {
            //  打开文件对话框
            OpenFileDialog openFileDialog = new OpenFileDialog();
            var rst = openFileDialog.ShowDialog();
            if (rst == DialogResult.OK)
            {
                var fileName = openFileDialog.FileName; // 获取文件路径
                                                        // 调用后台方法,获取数据
                studentList = NPOIService.ImportToList<StudentToExcel>(fileName);

                // 显示数据

                if (studentList.Count > 0)
                {
                    this.dgvStudentList.DataSource = null;
                    this.dgvStudentList.DataSource = studentList;

                }
                else
                {
                    this.dgvStudentList.DataSource = null;

                }
            }
        }
        private void dgvStudentList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Common.DataGridViewStyle.DgvRowPostPaint(this.dgvStudentList, e);
        }
        //保存到数据库
        private void btnSaveToDB_Click(object sender, EventArgs e)
        {
            if (this.dgvStudentList.RowCount ==0) return;

            try
            {
                bool isOk = ImportDataFromExcel.Import(studentList);
                if (isOk)
                {
                    MessageBox.Show("数据导入成功!","提示");
                    this.dgvStudentList.DataSource = null;
                    this.studentList.Clear();
                }
                else
                {
                    MessageBox.Show("数据导入失败!", "提示");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据导入失败! 具体原因:"+ex.Message,"提示");  
            }
           
        }
    }
}

