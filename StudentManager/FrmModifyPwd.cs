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
    public partial class FrmModifyPwd : Form
    {
        public FrmModifyPwd()
        {
            InitializeComponent();
        }
        //修改密码
        private void btnModify_Click(object sender, EventArgs e)
        {
            #region 密码验证
            if (this.txtOldPwd.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入原始密码!","提示信息");
                this.txtOldPwd.Focus();
                return;
            }
            if (this.txtOldPwd.Text.Trim() != Program.CurrentAdmin.LoginPwd)
            {
                MessageBox.Show("输入的原始密码不正确!","提示信息");
                this.txtOldPwd.Focus();
                this.txtOldPwd.SelectAll();
                return;
            }

            if (this.txtNewPwd.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入不少于6位数字的密码!", "提示信息");
                this.txtNewPwd.Focus();
                return;
            }


            if (this.txtNewPwd.Text.Trim().Length < 6)
            {
                MessageBox.Show("新密码的长度不能少于6位!", "提示信息");
                this.txtNewPwd.Focus();
                this.txtNewPwd.SelectAll();
                return;
            }

            if (this.txtNewPwdConfirm.Text.Trim().Length == 0)
            {
                MessageBox.Show("请再次输入新密码!","提示信息");
                this.txtNewPwdConfirm.Focus();
                return;
            }

            if (this.txtNewPwdConfirm.Text.Trim() != this.txtNewPwd.Text.Trim())
            {
                MessageBox.Show("两次输入的密码不一致!", "提示信息");
                this.txtNewPwd.Focus();
                this.txtNewPwd.SelectAll();
                this.txtNewPwdConfirm.SelectAll();
                return;
            }

            #endregion

            // 修改密码
            SysAdmin sysAdmin = new SysAdmin { LoginId =Program.CurrentAdmin.LoginId,LoginPwd = this.txtNewPwd.Text.Trim()};

            try
            {
                if (new SysAdminService().ModifyPwd(sysAdmin) == 1)
                {
                    MessageBox.Show("密码修改成功,请妥善保管!","提示信息");
                    Program.CurrentAdmin.LoginPwd = sysAdmin.LoginPwd;
                    this.Close();

                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
