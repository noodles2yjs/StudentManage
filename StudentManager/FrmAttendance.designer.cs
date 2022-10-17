namespace StudentManager
{
    partial class FrmAttendance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAttendance));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbStu = new System.Windows.Forms.PictureBox();
            this.txtStuCardNo = new System.Windows.Forms.TextBox();
            this.lblWeek = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lblStuClass = new System.Windows.Forms.Label();
            this.lblStuId = new System.Windows.Forms.Label();
            this.lblAbsenceCount = new System.Windows.Forms.Label();
            this.lblReal = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblStuName = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gp01 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvStudentList = new System.Windows.Forms.DataGridView();
            this.DTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbStu)).BeginInit();
            this.gp01.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentList)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbStu
            // 
            this.pbStu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbStu.Location = new System.Drawing.Point(24, 122);
            this.pbStu.Name = "pbStu";
            this.pbStu.Size = new System.Drawing.Size(179, 198);
            this.pbStu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStu.TabIndex = 95;
            this.pbStu.TabStop = false;
            // 
            // txtStuCardNo
            // 
            this.txtStuCardNo.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtStuCardNo.Location = new System.Drawing.Point(78, 142);
            this.txtStuCardNo.Name = "txtStuCardNo";
            this.txtStuCardNo.Size = new System.Drawing.Size(140, 35);
            this.txtStuCardNo.TabIndex = 0;
            this.txtStuCardNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStuCardNo_KeyDown);
            // 
            // lblWeek
            // 
            this.lblWeek.BackColor = System.Drawing.Color.Black;
            this.lblWeek.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWeek.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeek.ForeColor = System.Drawing.Color.Red;
            this.lblWeek.Location = new System.Drawing.Point(527, 75);
            this.lblWeek.Margin = new System.Windows.Forms.Padding(17, 0, 17, 0);
            this.lblWeek.Name = "lblWeek";
            this.lblWeek.Size = new System.Drawing.Size(45, 29);
            this.lblWeek.TabIndex = 77;
            this.lblWeek.Text = "0";
            this.lblWeek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDay
            // 
            this.lblDay.BackColor = System.Drawing.Color.Black;
            this.lblDay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDay.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.ForeColor = System.Drawing.Color.Red;
            this.lblDay.Location = new System.Drawing.Point(221, 75);
            this.lblDay.Margin = new System.Windows.Forms.Padding(17, 0, 17, 0);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(45, 29);
            this.lblDay.TabIndex = 79;
            this.lblDay.Text = "00";
            this.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMonth
            // 
            this.lblMonth.BackColor = System.Drawing.Color.Black;
            this.lblMonth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMonth.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.ForeColor = System.Drawing.Color.Red;
            this.lblMonth.Location = new System.Drawing.Point(137, 75);
            this.lblMonth.Margin = new System.Windows.Forms.Padding(17, 0, 17, 0);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(45, 29);
            this.lblMonth.TabIndex = 78;
            this.lblMonth.Text = "00";
            this.lblMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.Black;
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTime.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Red;
            this.lblTime.Location = new System.Drawing.Point(321, 75);
            this.lblTime.Margin = new System.Windows.Forms.Padding(17, 0, 17, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(134, 29);
            this.lblTime.TabIndex = 76;
            this.lblTime.Text = "00 : 00  00";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblYear
            // 
            this.lblYear.BackColor = System.Drawing.Color.Black;
            this.lblYear.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblYear.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.ForeColor = System.Drawing.Color.Red;
            this.lblYear.Location = new System.Drawing.Point(25, 75);
            this.lblYear.Margin = new System.Windows.Forms.Padding(17, 0, 17, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(73, 29);
            this.lblYear.TabIndex = 75;
            this.lblYear.Text = "0000";
            this.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(455, 70);
            this.label9.Margin = new System.Windows.Forms.Padding(17, 0, 17, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 39);
            this.label9.TabIndex = 72;
            this.label9.Text = "星期";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(266, 70);
            this.label6.Margin = new System.Windows.Forms.Padding(17, 0, 17, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 39);
            this.label6.TabIndex = 71;
            this.label6.Text = "日";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(182, 70);
            this.label5.Margin = new System.Windows.Forms.Padding(17, 0, 17, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 39);
            this.label5.TabIndex = 74;
            this.label5.Text = "月";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(17, 0, 17, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 39);
            this.label2.TabIndex = 73;
            this.label2.Text = "年";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(844, 70);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(104, 35);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "结束打卡";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(5, 26);
            this.label10.Margin = new System.Windows.Forms.Padding(17, 0, 17, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 39);
            this.label10.TabIndex = 89;
            this.label10.Text = "应到";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStuClass
            // 
            this.lblStuClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblStuClass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStuClass.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStuClass.ForeColor = System.Drawing.Color.Black;
            this.lblStuClass.Location = new System.Drawing.Point(571, 82);
            this.lblStuClass.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblStuClass.Name = "lblStuClass";
            this.lblStuClass.Size = new System.Drawing.Size(140, 39);
            this.lblStuClass.TabIndex = 84;
            this.lblStuClass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStuId
            // 
            this.lblStuId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblStuId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStuId.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStuId.ForeColor = System.Drawing.Color.Black;
            this.lblStuId.Location = new System.Drawing.Point(333, 82);
            this.lblStuId.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblStuId.Name = "lblStuId";
            this.lblStuId.Size = new System.Drawing.Size(140, 39);
            this.lblStuId.TabIndex = 85;
            this.lblStuId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAbsenceCount
            // 
            this.lblAbsenceCount.BackColor = System.Drawing.Color.White;
            this.lblAbsenceCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAbsenceCount.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAbsenceCount.ForeColor = System.Drawing.Color.Red;
            this.lblAbsenceCount.Location = new System.Drawing.Point(571, 26);
            this.lblAbsenceCount.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblAbsenceCount.Name = "lblAbsenceCount";
            this.lblAbsenceCount.Size = new System.Drawing.Size(140, 39);
            this.lblAbsenceCount.TabIndex = 82;
            this.lblAbsenceCount.Text = "0";
            this.lblAbsenceCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReal
            // 
            this.lblReal.BackColor = System.Drawing.Color.White;
            this.lblReal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblReal.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblReal.Location = new System.Drawing.Point(333, 26);
            this.lblReal.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblReal.Name = "lblReal";
            this.lblReal.Size = new System.Drawing.Size(140, 39);
            this.lblReal.TabIndex = 83;
            this.lblReal.Text = "0";
            this.lblReal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCount
            // 
            this.lblCount.BackColor = System.Drawing.Color.White;
            this.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCount.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCount.Location = new System.Drawing.Point(78, 26);
            this.lblCount.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(140, 39);
            this.lblCount.TabIndex = 81;
            this.lblCount.Text = "0";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStuName
            // 
            this.lblStuName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblStuName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStuName.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStuName.ForeColor = System.Drawing.Color.Black;
            this.lblStuName.Location = new System.Drawing.Point(78, 82);
            this.lblStuName.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblStuName.Name = "lblStuName";
            this.lblStuName.Size = new System.Drawing.Size(140, 39);
            this.lblStuName.TabIndex = 80;
            this.lblStuName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblInfo.ForeColor = System.Drawing.Color.Red;
            this.lblInfo.Location = new System.Drawing.Point(243, 150);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(74, 22);
            this.lblInfo.TabIndex = 96;
            this.lblInfo.Text = "准备打卡";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 31);
            this.label1.TabIndex = 97;
            this.label1.Text = "考勤打卡进行中...";
            // 
            // gp01
            // 
            this.gp01.Controls.Add(this.label4);
            this.gp01.Controls.Add(this.label3);
            this.gp01.Controls.Add(this.label11);
            this.gp01.Controls.Add(this.label8);
            this.gp01.Controls.Add(this.label12);
            this.gp01.Controls.Add(this.label7);
            this.gp01.Controls.Add(this.label10);
            this.gp01.Controls.Add(this.lblStuName);
            this.gp01.Controls.Add(this.lblInfo);
            this.gp01.Controls.Add(this.lblCount);
            this.gp01.Controls.Add(this.lblReal);
            this.gp01.Controls.Add(this.txtStuCardNo);
            this.gp01.Controls.Add(this.lblAbsenceCount);
            this.gp01.Controls.Add(this.lblStuId);
            this.gp01.Controls.Add(this.lblStuClass);
            this.gp01.Location = new System.Drawing.Point(237, 122);
            this.gp01.Name = "gp01";
            this.gp01.Size = new System.Drawing.Size(746, 198);
            this.gp01.TabIndex = 0;
            this.gp01.TabStop = false;
            this.gp01.Text = "[考勤信息]";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(498, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(17, 0, 17, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 39);
            this.label4.TabIndex = 89;
            this.label4.Text = "缺勤";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(258, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(17, 0, 17, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 39);
            this.label3.TabIndex = 89;
            this.label3.Text = "实到";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(498, 82);
            this.label11.Margin = new System.Windows.Forms.Padding(17, 0, 17, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 39);
            this.label11.TabIndex = 89;
            this.label11.Text = "班级";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(257, 82);
            this.label8.Margin = new System.Windows.Forms.Padding(17, 0, 17, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 39);
            this.label8.TabIndex = 89;
            this.label8.Text = "学号";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(5, 140);
            this.label12.Margin = new System.Windows.Forms.Padding(17, 0, 17, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 39);
            this.label12.TabIndex = 89;
            this.label12.Text = "卡号";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(6, 81);
            this.label7.Margin = new System.Windows.Forms.Padding(17, 0, 17, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 39);
            this.label7.TabIndex = 89;
            this.label7.Text = "姓名";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvStudentList
            // 
            this.dgvStudentList.AllowUserToAddRows = false;
            this.dgvStudentList.AllowUserToDeleteRows = false;
            this.dgvStudentList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudentList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStudentList.ColumnHeadersHeight = 30;
            this.dgvStudentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DTime,
            this.StudentId,
            this.CardNo,
            this.StudentName,
            this.Gender,
            this.ClassName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudentList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStudentList.EnableHeadersVisualStyles = false;
            this.dgvStudentList.Location = new System.Drawing.Point(24, 336);
            this.dgvStudentList.Name = "dgvStudentList";
            this.dgvStudentList.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudentList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStudentList.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvStudentList.RowTemplate.Height = 23;
            this.dgvStudentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudentList.Size = new System.Drawing.Size(959, 316);
            this.dgvStudentList.TabIndex = 98;
            // 
            // DTime
            // 
            this.DTime.DataPropertyName = "DTime";
            this.DTime.HeaderText = "打卡时间";
            this.DTime.Name = "DTime";
            this.DTime.ReadOnly = true;
            this.DTime.Width = 150;
            // 
            // StudentId
            // 
            this.StudentId.DataPropertyName = "StudentId";
            this.StudentId.HeaderText = "学号";
            this.StudentId.Name = "StudentId";
            this.StudentId.ReadOnly = true;
            this.StudentId.Width = 150;
            // 
            // CardNo
            // 
            this.CardNo.DataPropertyName = "CardNo";
            this.CardNo.HeaderText = "考勤卡号";
            this.CardNo.Name = "CardNo";
            this.CardNo.ReadOnly = true;
            this.CardNo.Width = 150;
            // 
            // StudentName
            // 
            this.StudentName.DataPropertyName = "StudentName";
            this.StudentName.HeaderText = "姓名";
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            this.StudentName.Width = 150;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "性别";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // ClassName
            // 
            this.ClassName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClassName.DataPropertyName = "ClassName";
            this.ClassName.HeaderText = "所在班级";
            this.ClassName.Name = "ClassName";
            this.ClassName.ReadOnly = true;
            // 
            // FrmAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 669);
            this.Controls.Add(this.dgvStudentList);
            this.Controls.Add(this.gp01);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbStu);
            this.Controls.Add(this.lblWeek);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmAttendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[考勤打卡进行中...]";

            ((System.ComponentModel.ISupportInitialize)(this.pbStu)).EndInit();
            this.gp01.ResumeLayout(false);
            this.gp01.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbStu;
        private System.Windows.Forms.TextBox txtStuCardNo;
        private System.Windows.Forms.Label lblWeek;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblStuClass;
        private System.Windows.Forms.Label lblStuId;
        private System.Windows.Forms.Label lblAbsenceCount;
        private System.Windows.Forms.Label lblReal;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblStuName;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gp01;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvStudentList;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
    }
}