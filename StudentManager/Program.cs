using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


using System.Diagnostics;
using Models;

namespace StudentManager
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //创建登录窗体
            FrmUserLogin frmUserLogin = new FrmUserLogin();
            DialogResult dialogResult = frmUserLogin.ShowDialog();

            // 根据窗体返回值,判断用户是否登录成功
            if (dialogResult == DialogResult.OK )
            {
                Application.Run(new FrmMain());
            }
            else
            {
                Application.Exit();// 退出 关闭程序,释放程序所占用的全部资源
            }

           

        }
        // 声明用户信息的全局变量
        public static SysAdmin CurrentAdmin = null;
    }
}
