using Models;
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

        public FrmStudentInfo(Student student) : this()
        {
            this.lblStudentName.Text = student.StudentName;
            this.lblStudentIdNo.Text = student.StudentIdNo;
            this.lblPhoneNumber.Text = student.PhoneNumber;
            //this.lblBirthday.Text = student.Birthday.ToString("d");
            this.lblBirthday.Text = student.Birthday.ToShortDateString();
            this.lblGender.Text = student.Gender;
            this.lblClass.Text = student.ClassName; 
            this.lblCardNo.Text = student.CardNo;
            this.lblAddress .Text= student.StudentAddress;
            this.pbStu.Image = student.StuImage.Length != 0 ? (Image)new SerializeObjectToString().DeserializeObject(student.StuImage) : Image.FromFile("default.png");

        }

        //¹Ø±Õ
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}