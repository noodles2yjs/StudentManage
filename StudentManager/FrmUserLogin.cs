using BLL;
using DAL;
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
    public partial class FrmUserLogin : Form
    {
        public FrmUserLogin()
        {
            InitializeComponent();
        }

        #region 属性和字段
        private SysAdminManage sysAdminManage = new SysAdminManage();
        #endregion


        //登录
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // 验证数据
            if (txtLoginId.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入登录账号!","提示信息");
                this.txtLoginId.Focus();
                return;
            }
            if (!DataValidate.IsInteger(txtLoginId.Text.Trim()))
            {
                MessageBox.Show("登录账号必须为正整数!", "提示信息");
                this.txtLoginPwd.Focus();
                return;
            }

            if (txtLoginPwd.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入登录密码!", "提示信息");
                this.txtLoginPwd.Focus();
                return;
            }

            // 封装数据

           var sysAdmin = new SysAdmin { LoginId = Convert.ToInt32(txtLoginId.Text.Trim()), LoginPwd = txtLoginPwd.Text.Trim() };

            try
            {
                Program.CurrentAdmin = sysAdminManage.AdminLogin(sysAdmin);
                if (Program.CurrentAdmin != null)
                {
                    this.DialogResult = DialogResult.OK;
                   // this.Close();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误!", "提示信息");
                }
            }
            catch (Exception ex)
            {

                //  MessageBox.Show(ex.Message,"提示信息");//
                throw ex;

            }


        }
        //关闭
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
