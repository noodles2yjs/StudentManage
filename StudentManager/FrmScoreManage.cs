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

            //��ʼ���༶������
            List<StudentClass> studentClasses = this.studentClassManage.GetAllClass();
            this.cboClass.DataSource = studentClasses;
            // �������������ʾ�ı�
            this.cboClass.DisplayMember = "ClassName";
            // �������������ʾ�ı���Ӧ��Value
            this.cboClass.ValueMember = "ClassId";
            this.cboClass.SelectedIndex = -1;
            this.cboClass.SelectedIndexChanged += new System.EventHandler(this.cboClass_SelectedIndexChanged);
            // ����dgv����ʽ
            new DataGridViewStyle().DgvStyle1(this.dgvScoreList);

        }

        #region ���Ժ��ֶ�
        private StudentClassManage studentClassManage = new StudentClassManage();
        private ScoreManage  scoreManage= new ScoreManage();

        private List<ExtStudent> extStudentList= new List<ExtStudent>();


        #endregion
        //���ݰ༶��ѯ      
        private void cboClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboClass.SelectedIndex==-1)
            {
                MessageBox.Show("��ѡ��༶","��ʾ");
                return;
            }

            // �����ݿ��ȡ����dgv�б�����
            extStudentList = scoreManage.GetScoreList(this.cboClass.Text.Trim());
            if (extStudentList.Count >0)
            {
                this.dgvScoreList.DataSource = extStudentList;
            }
            else
            {
                this.dgvScoreList.DataSource = null;
            }

            // ͬ����ʾ�༶����ͳ����Ϣ

            this.gbStat.Text = "[" + this.cboClass.Text.Trim() + "]���Գɼ�ͳ�� ";
            Dictionary<string, string> classStatInfoDic = scoreManage.GetClassStatInfo(this.cboClass.SelectedValue.ToString());

            this.lblAbsentCount.Text = classStatInfoDic["absentCount"];
            this.lblAttendCount.Text= classStatInfoDic["stuCount"];
            this.lblCSharpAvg.Text = classStatInfoDic["avgCSharp"];
            this.lblDBAvg.Text = classStatInfoDic["avgDB"];

            //��ʾȱ����Ա����

          var list = scoreManage.GetAbsentStudentNameList(this.cboClass.SelectedValue.ToString()).ToArray();
            this.lblList.Items.Clear();
            if (list.Length ==0)
            {
                this.lblList.Items.Add("û��ȱ��");
            }
            else
            {
                this.lblList.Items.AddRange(list);
            }
           


        }
        //�ر�
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //ͳ��ȫУ���Գɼ�
        private void btnStat_Click(object sender, EventArgs e)
        {
            // �����ݿ��ȡ����dgv�б�����
            extStudentList = scoreManage.GetScoreList("");
            if (extStudentList.Count > 0)
            {
                this.dgvScoreList.DataSource = extStudentList;
            }

            // ͬ����ʾ�༶����ͳ����Ϣ

            this.gbStat.Text = "ȫУ���Գɼ�ͳ��";
            Dictionary<string, string> classStatInfoDic = scoreManage.GetClassStatInfo("");

            this.lblAbsentCount.Text = classStatInfoDic["absentCount"];
            this.lblAttendCount.Text = classStatInfoDic["stuCount"];
            this.lblCSharpAvg.Text = classStatInfoDic["avgCSharp"];
            this.lblDBAvg.Text = classStatInfoDic["avgDB"];

            // ��ʾȱ����Ա��Ϣ
            //��ʾȱ����Ա����
            this.lblList.Items.Clear();
            string[] AbsentStudentList = scoreManage.GetAbsentStudentNameList("").ToArray();
            if (AbsentStudentList.Length == 0) this.lblList.Items.Add("û��ȱ��");
            this.lblList.Items.AddRange(AbsentStudentList);

        }

        private void dgvScoreList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewStyle.DgvRowPostPaint(this.dgvScoreList, e);
        }

    
     
        //ѡ���ѡ��ı䴦��
        private void dgvScoreList_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
         
        }
        /// <summary>
        /// �����������
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