using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace StudentManager
{
    public partial class FrmStudentInfo : Form
    {
        public FrmStudentInfo()
        {
            InitializeComponent();
        }
      
        //¹Ø±Õ
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}