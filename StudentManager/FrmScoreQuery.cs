using BLL;
using Common;
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
    public partial class FrmScoreQuery : Form
    {
           
        public FrmScoreQuery()
        {
            InitializeComponent();
            this.dgvScoreList.AutoGenerateColumns= false;
            // 初始化班级下拉框
            this.cboClass.DataSource = classManage.GetAllClass();
            this.cboClass.DisplayMember= "ClassName";
            this.cboClass.ValueMember= "ClassId";

            this.cboClass.SelectedIndexChanged += new System.EventHandler(this.cboClass_SelectedIndexChanged);//放在这里,避免初始化时触发cboClass_SelectedIndexChanged 事件

            // 显示全部考试成绩
            ds = scoreManage.GetAllScoreList();
            this.dgvScoreList.DataSource = ds.Tables[0];
            new DataGridViewStyle().DgvStyle2(this.dgvScoreList);
            // 禁止列排序
            foreach (DataGridViewColumn item in this.dgvScoreList.Columns)
            {
                item.SortMode = DataGridViewColumnSortMode.NotSortable;
            }


        }

        #region 属性和字段
        private DataSet ds = null;//保存全部查询结果的数据集
        private StudentClassManage classManage = new StudentClassManage();
        private ScoreManage scoreManage = new ScoreManage();

        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //根据班级名称动态筛选
        private void cboClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cboClass.SelectedIndex == -1) return;
            if (ds == null) return;

            this.ds.Tables[0].DefaultView.RowFilter = $"ClassName = '{this.cboClass.Text.Trim()}'";


        }
        //显示全部成绩
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            this.ds.Tables[0].DefaultView.RowFilter = "ClassName like '%%'";
        }
        //根据C#成绩动态筛选
        private void txtScore_TextChanged(object sender, EventArgs e)
        {
            if (DataValidate.IsInteger(this.txtScore.Text))
            {
                this.ds.Tables[0].DefaultView.RowFilter =$"CSharp >{this.txtScore.Text}";
            }
        }

        private void dgvScoreList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
           Common.DataGridViewStyle.DgvRowPostPaint(this.dgvScoreList, e);
        }

        //打印当前的成绩信息
        private void btnPrint_Click(object sender, EventArgs e)
        {
            new ExcelPrint.DataExport().Export(this.dgvScoreList);
        }
    }
}
