using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Configuration;
using BLL;
using Models;
using Menu = Models.Menu;
using System.Linq;
using System.Reflection;

namespace StudentManager
{
    public partial class FrmMain_TreeView : Form
    {
        public FrmMain_TreeView()
        {
            InitializeComponent();
            // ��ʾ��ǰ�û�,
            this.lblCurrentUser.Text = Program.CurrentAdmin.AdminName;
            this.lblVersion.Text = "��ǰ�汾: V" + ConfigurationManager.AppSettings["pversion"].ToString();

            // ��ʾ�����屳��
            //��ʾ�����屳��
            this.spContainer.Panel2.BackgroundImage = Image.FromFile("mainbg.jpg");
            this.spContainer.Panel2.BackgroundImageLayout = ImageLayout.Stretch;

            // �������
            this.WindowState= FormWindowState.Maximized;

            // �������β˵�

            LoadTreeViewMenu();

        }
        #region ���Ժ��ֶ�
        private MenuManage menuManage = new MenuManage();
        private List<Menu> menuList = new List<Menu>();
        #endregion

        private void LoadTreeViewMenu()
        {
             menuList = menuManage.GetAllMeus(); // �������в˵��ڵ���Ϣ
            // ����һ�����ڵ�:
            this.treeView1.Nodes.Clear();
            TreeNode rootNode = new TreeNode();
            rootNode.Text = "ѧ������ϵͳ";
            rootNode.Tag = "0";// Ĭ��ֵ,Tag ���游�ڵ�Id
            rootNode.ImageIndex= 0;
            this.treeView1.Nodes.Add(rootNode);
            // �ݹ�����ֽڵ�

            CreateChildNote(rootNode,0);
          // this.treeView1.Nodes[0].Expand();// �ݹ���һ��չ��
            this.treeView1.ExpandAll();
        }

      private void CreateChildNote(TreeNode parentNode,int pId)
        {
            // �ҵ������Ըýڵ�Ϊ���ڵ������
            var nodes = menuList.Where(m =>   m.ParentId == pId).ToList();
           //var nodes = from list in menuList where list.ParentId== pId select list;

            // ѭ�������ýڵ�Ķ����ӽڵ�

            foreach (Menu item in nodes)
            {
                // �����µĽڵ㲢��������
                TreeNode node = new TreeNode();
                node.Text = item.MenuName;
                node.Tag = item.MenuCode;
                // ���ýڵ�ͼ��

                if (item.ParentId == 0)
                {
                    node.ImageIndex = 2;
                }
                else
                {
                    node.ImageIndex= 3;               
                }

                parentNode.Nodes.Add(node);// �ӽڵ���븸�ڵ�
                CreateChildNote(node, item.MenuId);// �ݹ�����ӽڵ�

            }
        }
      

        #region �ر���������

        private void ClosePreForm()
        {
            foreach (var control in this.spContainer.Panel2.Controls)
            {
                if (control is Form f)
                {
                    f.Close();
                }
            }
        }
        #endregion

        #region ���Ӵ���
         private void OpenNewForm(Form newForm)
        {
            ClosePreForm();
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Parent = this.spContainer.Panel2;
            newForm.Dock = DockStyle.Fill;
            newForm.Show();
        }
        #endregion

        #region Ƕ�봰����ʾ


        //��ʾ�����ѧԱ����       
        private void tsmiAddStudent_Click(object sender, EventArgs e)
        {
            btnAddStu_Click(null,null);
        }
        private void btnAddStu_Click(object sender, EventArgs e)
        {            
            OpenNewForm(new FrmAddStudent());
        }
        //��������ѧԱ��Ϣ
        private void tsmi_Import_Click(object sender, EventArgs e)
        {
            FrmImportData objForm = new FrmImportData();
            OpenNewForm(objForm);
        }
        private void btnImportStu_Click(object sender, EventArgs e)
        {
            tsmi_Import_Click(null, null);
        }
        //���ڴ�      
        private void tsmi_Card_Click(object sender, EventArgs e)
        {
            FrmAttendance objForm = new FrmAttendance();
            OpenNewForm(objForm);
        }
        private void btnCard_Click(object sender, EventArgs e)
        {
            tsmi_Card_Click(null, null);
        }
        //�ɼ����ٲ�ѯ��Ƕ����ʾ��
        private void tsmiQuery_Click(object sender, EventArgs e)
        {
            FrmScoreQuery objForm = new FrmScoreQuery();
           OpenNewForm(objForm);
        }
        private void btnScoreQuery_Click(object sender, EventArgs e)
        {
            tsmiQuery_Click(null, null);
        }
        //ѧԱ����Ƕ����ʾ��
        private void tsmiManageStudent_Click(object sender, EventArgs e)
        {
            btnStuManage_Click(null,null);
           // OpenForm(objForm);
        }
        private void btnStuManage_Click(object sender, EventArgs e)
        {

            FrmStudentManage objForm = new FrmStudentManage();
            OpenNewForm(objForm);
          //  tsmiManageStudent_Click(null, null);
        }
        //��ʾ�ɼ���ѯ���������    
        private void tsmiQueryAndAnalysis_Click(object sender, EventArgs e)
        {
            FrmScoreManage objForm = new FrmScoreManage();
           OpenNewForm(objForm);
        }
        private void btnScoreAnalasys_Click(object sender, EventArgs e)
        {
            tsmiQueryAndAnalysis_Click(null, null);
        }
        //���ڲ�ѯ
        private void tsmi_AQuery_Click(object sender, EventArgs e)
        {
            FrmAttendanceQuery objForm = new FrmAttendanceQuery();
           OpenNewForm(objForm);
        }
        private void btnAttendanceQuery_Click(object sender, EventArgs e)
        {
            tsmi_AQuery_Click(null, null);
        }

        #endregion

        #region �˳�ϵͳȷ��

        //�˳�ϵͳ
        private void tmiClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("ȷ���˳���?", "ȷ���˳�",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if ( dialogResult != DialogResult.OK)
            {
                e.Cancel = true;
            }

            // ��Ҫд����Ĵ���, ����
           // Application.Exit();
        }

        #endregion

        #region ����

        //�����޸�
        private void tmiModifyPwd_Click(object sender, EventArgs e)
        {
            FrmModifyPwd objPwd = new FrmModifyPwd();
            objPwd.ShowDialog();
        }
        private void btnModifyPwd_Click(object sender, EventArgs e)
        {
            tmiModifyPwd_Click(null, null);
        }
        //�˺��л�
        /*  private void btnChangeAccount_Click(object sender, EventArgs e)
          {
              /// �����˼·
              DialogResult dialogResult
                  = MessageBox.Show("ȷ���л��˻���","��ʾ��Ϣ", MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
              if (dialogResult == DialogResult.OK)
              {
                  this.Hide();
                  new FrmUserLogin().ShowDialog();
                  Program.CurrentAdmin = null;

              }
          }*/
        //�˺��л� 
        private void btnChangeAccount_Click(object sender, EventArgs e)
        {
            /// ֱ�Ӵ򿪵�¼����
            FrmUserLogin frmUserLogin = new FrmUserLogin();
            frmUserLogin.Text = "[�л��˺�]";
            DialogResult dialogResult = frmUserLogin.ShowDialog();
            // ���ߴ��巵��ֵ �ж��û���¼�Ƿ�ɹ�
            if (dialogResult == DialogResult.OK)
            {
                this.lblCurrentUser.Text = Program.CurrentAdmin.AdminName;
            }

        }
        private void tsbAddStudent_Click(object sender, EventArgs e)
        {
            tsmiAddStudent_Click(null, null);
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            tsmiManageStudent_Click(null, null);
        }
        private void tsbScoreAnalysis_Click(object sender, EventArgs e)
        {
            tsmiQueryAndAnalysis_Click(null, null);
        }
        private void tsbModifyPwd_Click(object sender, EventArgs e)
        {
            tmiModifyPwd_Click(null, null);
        }
        private void tsbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void tsbQuery_Click(object sender, EventArgs e)
        {
            tsmiQuery_Click(null, null);
        }

        //���ʹ���
        private void tsmi_linkxkt_Click(object sender, EventArgs e)
        {
         
        }
        private void btnGoXiketang_Click(object sender, EventArgs e)
        {
            tsmi_linkxkt_Click(null, null);
        }
        //ϵͳ����
        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }


        #endregion
        /// <summary>
        /// ���treeView�ڵ��ִ�е��¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Level == 2)
            {
              Form newForm= (Form) Assembly.Load("StudentManager").CreateInstance("StudentManager.Frm" + e.Node.Tag.ToString()); // CreateInstance() ������Ҫ��ȫ�޶���

                OpenNewForm(newForm);
            }
        }

        private void treeView1_AfterExpand(object sender, TreeViewEventArgs e)
        {
            e.Node.ImageIndex= 1;
        }

        private void treeView1_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            e.Node.ImageIndex = 2;
        }
    }
}