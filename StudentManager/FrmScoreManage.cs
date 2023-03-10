using BLL;
using Common;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;


namespace StudentManager
{
    public partial class FrmScoreManage : Form
    {     
        public FrmScoreManage()
        {
            InitializeComponent();
            this.dgvScoreList.AutoGenerateColumns= false;

            //初始化班级下拉框
            List<StudentClass> studentClasses = this.studentClassManage.GetAllClass();
            this.cboClass.DataSource = studentClasses;
            // 设置下拉框的显示文本
            this.cboClass.DisplayMember = "ClassName";
            // 设置下拉框的显示文本对应的Value
            this.cboClass.ValueMember = "ClassId";
            this.cboClass.SelectedIndex = -1;
            this.cboClass.SelectedIndexChanged += new System.EventHandler(this.cboClass_SelectedIndexChanged);
            // 设置dgv的样式
            new DataGridViewStyle().DgvStyle1(this.dgvScoreList);

        }

        #region 属性和字段
        private StudentClassManage studentClassManage = new StudentClassManage();
        private ScoreManage  scoreManage= new ScoreManage();

        private List<ExtStudent> extStudentList= new List<ExtStudent>();


        #endregion
        //根据班级查询      
        private void cboClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboClass.SelectedIndex==-1)
            {
                MessageBox.Show("请选择班级","提示");
                return;
            }

            // 从数据库获取所有dgv列表内容
            extStudentList = scoreManage.GetScoreList(this.cboClass.Text.Trim());
            if (extStudentList.Count >0)
            {
                this.dgvScoreList.DataSource = extStudentList;
            }
            else
            {
                this.dgvScoreList.DataSource = null;
            }

            // 同步显示班级考试统计信息

            this.gbStat.Text = "[" + this.cboClass.Text.Trim() + "]考试成绩统计 ";
            Dictionary<string, string> classStatInfoDic = scoreManage.GetClassStatInfo(this.cboClass.SelectedValue.ToString());

            this.lblAbsentCount.Text = classStatInfoDic["absentCount"];
            this.lblAttendCount.Text= classStatInfoDic["stuCount"];
            this.lblCSharpAvg.Text = classStatInfoDic["avgCSharp"];
            this.lblDBAvg.Text = classStatInfoDic["avgDB"];

            //显示缺考人员姓名

          var list = scoreManage.GetAbsentStudentNameList(this.cboClass.SelectedValue.ToString()).ToArray();
            this.lblList.Items.Clear();
            if (list.Length ==0)
            {
                this.lblList.Items.Add("没有缺考");
            }
            else
            {
                this.lblList.Items.AddRange(list);
            }
           


        }
        //关闭
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //统计全校考试成绩
        private void btnStat_Click(object sender, EventArgs e)
        {
            // 从数据库获取所有dgv列表内容
            extStudentList = scoreManage.GetScoreList("");
            if (extStudentList.Count > 0)
            {
                this.dgvScoreList.DataSource = extStudentList;
            }

            // 同步显示班级考试统计信息

            this.gbStat.Text = "全校考试成绩统计";
            Dictionary<string, string> classStatInfoDic = scoreManage.GetClassStatInfo("");

            this.lblAbsentCount.Text = classStatInfoDic["absentCount"];
            this.lblAttendCount.Text = classStatInfoDic["stuCount"];
            this.lblCSharpAvg.Text = classStatInfoDic["avgCSharp"];
            this.lblDBAvg.Text = classStatInfoDic["avgDB"];

            // 显示缺考人员信息
            //显示缺考人员姓名
            this.lblList.Items.Clear();
            string[] AbsentStudentList = scoreManage.GetAbsentStudentNameList("").ToArray();
            if (AbsentStudentList.Length == 0) this.lblList.Items.Add("没有缺考");
            this.lblList.Items.AddRange(AbsentStudentList);

        }

        private void dgvScoreList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewStyle.DgvRowPostPaint(this.dgvScoreList, e);
        }

    
     
        //选择框选择改变处理
        private void dgvScoreList_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
         
        }
        /// <summary>
        /// 解析组合属性
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvScoreList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.Value is Student s)
            {
                e.Value = s.StudentId;
            }

            if (e.ColumnIndex == 1 && e.Value is Student s1)
            {
                e.Value = s1.StudentName;
            }
            if (e.ColumnIndex == 2 && e.Value is Student s2)
            {
                e.Value = s2.Gender;
            }
            if (e.ColumnIndex == 4 && e.Value is ScoreList sc)
            {
                e.Value = sc.Csharp;
            }

            if (e.ColumnIndex == 5 && e.Value is ScoreList sc1)
            {
                e.Value = sc1.SQLServerDB;
            }
        }
    }
}