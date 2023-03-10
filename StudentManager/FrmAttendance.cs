using BLL;
using Common;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;


namespace StudentManager
{
    public partial class FrmAttendance : Form
    {
     
        public FrmAttendance()
        {
            InitializeComponent();   
            // 获取应到人数
            this.lblCount.Text = attendanceManage.GetAllStudentCount();
            timer1_Tick(null, null);
            ShowStat();
            this.Load += FrmAttendance_Load;
            this.dgvStudentList.AutoGenerateColumns = false;
            new DataGridViewStyle().DgvStyle2(this.dgvStudentList);
            studentRecordList = attendanceManage.GetAttendanceStudentList(DateTime.Now, true);
            studentRecordList= studentRecordList.OrderByDescending(e=>e.DTime).ToList();
            this.dgvStudentList.DataSource= studentRecordList;
        }

        private void FrmAttendance_Load(object sender, EventArgs e)
        {
            this.txtStuCardNo.Focus();
        }

        #region 属性和字段
        private AttendanceManage attendanceManage = new AttendanceManage();
        private List<Student> studentRecordList = new List<Student>();

        
        #endregion
        private void ShowStat()
        {
            try
            {
                // 显示出勤人数
                this.lblReal.Text = attendanceManage.GetAttendaceStudentCount(DateTime.Now,true);

                //显示缺勤人数

                this.lblAbsenceCount.Text = (Convert.ToInt32(this.lblCount.Text) - Convert.ToInt32(this.lblReal.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"提示");
            }
        }
        //显示当前时间
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lblYear.Text = DateTime.Now.Year.ToString();
            this.lblMonth.Text = DateTime.Now.Month.ToString();
            this.lblDay.Text = DateTime.Now.Day.ToString();

            this.lblTime.Text = DateTime.Now.ToLongTimeString();
            //this.lblTime.Text = DateTime.Now.ToLongDateString();

            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    this.lblWeek.Text = "日";
                    break;
                case DayOfWeek.Monday:
                    this.lblWeek.Text = "一";
                    break;
                case DayOfWeek.Tuesday:
                    this.lblWeek.Text = "二";
                    break;
                case DayOfWeek.Wednesday:
                    this.lblWeek.Text = "三";
                    break;
                case DayOfWeek.Thursday:
                    this.lblWeek.Text = "四";
                    break;
                case DayOfWeek.Friday:
                    this.lblWeek.Text = "五";
                    break;
                case DayOfWeek.Saturday:
                    this.lblWeek.Text = "六";
                    break;
                default:
                    break;
            }
        }
        //学员打卡        
        private void txtStuCardNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.txtStuCardNo.Text.Trim().Length !=0 && e.KeyValue == 13)
            {
                // 显示学员信息
               
                try
                {
                    Student student = attendanceManage.GetStudentByCardNo(this.txtStuCardNo.Text.Trim());

                    this.lblStuName.Text = student.StudentName;
                    this.lblStuId.Text = student.StudentId.ToString();
                    this.lblStuClass.Text = student.ClassName;

                    this.pbStu.Image = student.StuImage.Length != 0 ? (Image)new SerializeObjectToString().DeserializeObject(student.StuImage) : Image.FromFile("default.png");
                   
                }
                catch (Exception ex)
                {
                  
                       
                        this.lblInfo.Text = "打卡失败！";
                        this.txtStuCardNo.SelectAll();
                        this.lblStuName.Text = "";
                        this.lblStuClass.Text = "";
                        this.lblStuId.Text = "";
                        this.pbStu.Image = null;
                        MessageBox.Show("卡号不正确: "+ex.Message, "信息提示");
                        return;
                   
                }

                
            
                // 添加打卡信息
                try
                {
                    attendanceManage.AddRecord(this.txtStuCardNo.Text.Trim());
                    ShowStat();
                    this.lblInfo.Text = "打卡成功！";
                }
                catch (Exception ex)
                {

                    MessageBox.Show("添加记录失败: "+ex.Message,"提示");
                    return;
                }



                //打卡记录同步显示在dgv中
                // attendanceManage.get
                studentRecordList = attendanceManage.GetAttendanceStudentList(DateTime.Now, true);
                studentRecordList = studentRecordList.OrderByDescending(e2 => e2.DTime).ToList();
                if (studentRecordList.Count>0)
                {
                    this.dgvStudentList.DataSource = null;
                    this.dgvStudentList.DataSource = studentRecordList;
                }
                else
                {
                    this.dgvStudentList.DataSource = null;
                }

            }
        }
        //结束打卡
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvStudentList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Common.DataGridViewStyle.DgvRowPostPaint(this.dgvStudentList, e);
        }
    }
}
