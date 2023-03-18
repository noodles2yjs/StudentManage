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
            // 显示当前用户,
            this.lblCurrentUser.Text = Program.CurrentAdmin.AdminName;
            this.lblVersion.Text = "当前版本: V" + ConfigurationManager.AppSettings["pversion"].ToString();

            // 显示主窗体背景
            //显示主窗体背景
            this.spContainer.Panel2.BackgroundImage = Image.FromFile("mainbg.jpg");
            this.spContainer.Panel2.BackgroundImageLayout = ImageLayout.Stretch;

            // 窗体最大化
            this.WindowState= FormWindowState.Maximized;

            // 加载树形菜单

            LoadTreeViewMenu();

        }
        #region 属性和字段
        private MenuManage menuManage = new MenuManage();
        private List<Menu> menuList = new List<Menu>();
        #endregion

        private void LoadTreeViewMenu()
        {
             menuList = menuManage.GetAllMeus(); // 加载所有菜单节点信息
            // 创建一个根节点:
            this.treeView1.Nodes.Clear();
            TreeNode rootNode = new TreeNode();
            rootNode.Text = "学生管理系统";
            rootNode.Tag = "0";// 默认值,Tag 储存父节点Id
            rootNode.ImageIndex= 0;
            this.treeView1.Nodes.Add(rootNode);
            // 递归添加字节点

            CreateChildNote(rootNode,0);
          // this.treeView1.Nodes[0].Expand();// 递归树一级展开
            this.treeView1.ExpandAll();
        }

      private void CreateChildNote(TreeNode parentNode,int pId)
        {
            // 找到所有以该节点为父节点的子项
            var nodes = menuList.Where(m =>   m.ParentId == pId).ToList();
           //var nodes = from list in menuList where list.ParentId== pId select list;

            // 循环创建该节点的多有子节点

            foreach (Menu item in nodes)
            {
                // 创建新的节点并设置属性
                TreeNode node = new TreeNode();
                node.Text = item.MenuName;
                node.Tag = item.MenuCode;
                // 设置节点图标

                if (item.ParentId == 0)
                {
                    node.ImageIndex = 2;
                }
                else
                {
                    node.ImageIndex= 3;               
                }

                parentNode.Nodes.Add(node);// 子节点加入父节点
                CreateChildNote(node, item.MenuId);// 递归添加子节点

            }
        }
      

        #region 关闭其他窗体

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

        #region 打开子窗体
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

        #region 嵌入窗体显示


        //显示添加新学员窗体       
        private void tsmiAddStudent_Click(object sender, EventArgs e)
        {
            btnAddStu_Click(null,null);
        }
        private void btnAddStu_Click(object sender, EventArgs e)
        {            
            OpenNewForm(new FrmAddStudent());
        }
        //批量导入学员信息
        private void tsmi_Import_Click(object sender, EventArgs e)
        {
            FrmImportData objForm = new FrmImportData();
            OpenNewForm(objForm);
        }
        private void btnImportStu_Click(object sender, EventArgs e)
        {
            tsmi_Import_Click(null, null);
        }
        //考勤打卡      
        private void tsmi_Card_Click(object sender, EventArgs e)
        {
            FrmAttendance objForm = new FrmAttendance();
            OpenNewForm(objForm);
        }
        private void btnCard_Click(object sender, EventArgs e)
        {
            tsmi_Card_Click(null, null);
        }
        //成绩快速查询【嵌入显示】
        private void tsmiQuery_Click(object sender, EventArgs e)
        {
            FrmScoreQuery objForm = new FrmScoreQuery();
           OpenNewForm(objForm);
        }
        private void btnScoreQuery_Click(object sender, EventArgs e)
        {
            tsmiQuery_Click(null, null);
        }
        //学员管理【嵌入显示】
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
        //显示成绩查询与分析窗口    
        private void tsmiQueryAndAnalysis_Click(object sender, EventArgs e)
        {
            FrmScoreManage objForm = new FrmScoreManage();
           OpenNewForm(objForm);
        }
        private void btnScoreAnalasys_Click(object sender, EventArgs e)
        {
            tsmiQueryAndAnalysis_Click(null, null);
        }
        //考勤查询
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

        #region 退出系统确认

        //退出系统
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
            DialogResult dialogResult = MessageBox.Show("确认退出吗?", "确认退出",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if ( dialogResult != DialogResult.OK)
            {
                e.Cancel = true;
            }

            // 不要写多余的代码, 比如
           // Application.Exit();
        }

        #endregion

        #region 其他

        //密码修改
        private void tmiModifyPwd_Click(object sender, EventArgs e)
        {
            FrmModifyPwd objPwd = new FrmModifyPwd();
            objPwd.ShowDialog();
        }
        private void btnModifyPwd_Click(object sender, EventArgs e)
        {
            tmiModifyPwd_Click(null, null);
        }
        //账号切换
        /*  private void btnChangeAccount_Click(object sender, EventArgs e)
          {
              /// 错误的思路
              DialogResult dialogResult
                  = MessageBox.Show("确定切换账户吗","提示信息", MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
              if (dialogResult == DialogResult.OK)
              {
                  this.Hide();
                  new FrmUserLogin().ShowDialog();
                  Program.CurrentAdmin = null;

              }
          }*/
        //账号切换 
        private void btnChangeAccount_Click(object sender, EventArgs e)
        {
            /// 直接打开登录界面
            FrmUserLogin frmUserLogin = new FrmUserLogin();
            frmUserLogin.Text = "[切换账号]";
            DialogResult dialogResult = frmUserLogin.ShowDialog();
            // 更具窗体返回值 判断用户登录是否成功
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

        //访问官网
        private void tsmi_linkxkt_Click(object sender, EventArgs e)
        {
         
        }
        private void btnGoXiketang_Click(object sender, EventArgs e)
        {
            tsmi_linkxkt_Click(null, null);
        }
        //系统升级
        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }


        #endregion
        /// <summary>
        /// 点击treeView节点后执行的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Level == 2)
            {
              Form newForm= (Form) Assembly.Load("StudentManager").CreateInstance("StudentManager.Frm" + e.Node.Tag.ToString()); // CreateInstance() 参数需要完全限定名

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