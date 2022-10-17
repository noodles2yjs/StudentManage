namespace StudentManager
{
    partial class FrmAddStudent
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddStudent));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStudentIdNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cboClassName = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.pbStu = new System.Windows.Forms.PictureBox();
            this.btnChoseImage = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.gbstuinfo = new System.Windows.Forms.GroupBox();
            this.pbVideo = new System.Windows.Forms.PictureBox();
            this.btnStartVideo = new System.Windows.Forms.Button();
            this.btnTake = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCloseVideo = new System.Windows.Forms.Button();
            this.dgvStudentList = new System.Windows.Forms.DataGridView();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbStu)).BeginInit();
            this.gbstuinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "学生姓名：";
            // 
            // txtStudentName
            // 
            this.txtStudentName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudentName.Location = new System.Drawing.Point(91, 32);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(142, 21);
            this.txtStudentName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "性别：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "出生日期：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "身份证号：";
            // 
            // txtStudentIdNo
            // 
            this.txtStudentIdNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudentIdNo.Location = new System.Drawing.Point(91, 70);
            this.txtStudentIdNo.Name = "txtStudentIdNo";
            this.txtStudentIdNo.Size = new System.Drawing.Size(276, 21);
            this.txtStudentIdNo.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(684, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "联系电话：";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhoneNumber.Location = new System.Drawing.Point(755, 70);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(167, 21);
            this.txtPhoneNumber.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "家庭住址：";
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Location = new System.Drawing.Point(91, 107);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(544, 21);
            this.txtAddress.TabIndex = 8;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(300, 34);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(35, 16);
            this.rdoMale.TabIndex = 1;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "男";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(341, 34);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(35, 16);
            this.rdoFemale.TabIndex = 2;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "女";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthday.Location = new System.Drawing.Point(492, 32);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(143, 21);
            this.dtpBirthday.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(684, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "所在班级：";
            // 
            // cboClassName
            // 
            this.cboClassName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClassName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboClassName.FormattingEnabled = true;
            this.cboClassName.Location = new System.Drawing.Point(755, 34);
            this.cboClassName.Name = "cboClassName";
            this.cboClassName.Size = new System.Drawing.Size(167, 20);
            this.cboClassName.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(868, 215);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 35);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "确认添加";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(868, 70);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(87, 35);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "关闭窗口";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(421, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "考勤卡号：";
            // 
            // txtCardNo
            // 
            this.txtCardNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCardNo.Location = new System.Drawing.Point(492, 70);
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.Size = new System.Drawing.Size(143, 21);
            this.txtCardNo.TabIndex = 6;
            // 
            // pbStu
            // 
            this.pbStu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbStu.Location = new System.Drawing.Point(506, 72);
            this.pbStu.Name = "pbStu";
            this.pbStu.Size = new System.Drawing.Size(207, 178);
            this.pbStu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStu.TabIndex = 11;
            this.pbStu.TabStop = false;
            // 
            // btnChoseImage
            // 
            this.btnChoseImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChoseImage.ImageIndex = 2;
            this.btnChoseImage.ImageList = this.imageList1;
            this.btnChoseImage.Location = new System.Drawing.Point(265, 215);
            this.btnChoseImage.Name = "btnChoseImage";
            this.btnChoseImage.Size = new System.Drawing.Size(103, 35);
            this.btnChoseImage.TabIndex = 12;
            this.btnChoseImage.Text = "选择照片 ";
            this.btnChoseImage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChoseImage.UseVisualStyleBackColor = true;
            this.btnChoseImage.Click += new System.EventHandler(this.btnChoseImage_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "4.png");
            this.imageList1.Images.SetKeyName(1, "lklLoginExit.ico");
            this.imageList1.Images.SetKeyName(2, "turn.BMP");
            this.imageList1.Images.SetKeyName(3, "5.jpg");
            this.imageList1.Images.SetKeyName(4, "exit.ico");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.Purple;
            this.label9.Location = new System.Drawing.Point(27, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 31);
            this.label9.TabIndex = 0;
            this.label9.Text = "添加新学员";
            // 
            // gbstuinfo
            // 
            this.gbstuinfo.Controls.Add(this.txtStudentName);
            this.gbstuinfo.Controls.Add(this.label1);
            this.gbstuinfo.Controls.Add(this.label2);
            this.gbstuinfo.Controls.Add(this.label3);
            this.gbstuinfo.Controls.Add(this.rdoMale);
            this.gbstuinfo.Controls.Add(this.txtAddress);
            this.gbstuinfo.Controls.Add(this.label6);
            this.gbstuinfo.Controls.Add(this.cboClassName);
            this.gbstuinfo.Controls.Add(this.rdoFemale);
            this.gbstuinfo.Controls.Add(this.txtPhoneNumber);
            this.gbstuinfo.Controls.Add(this.label5);
            this.gbstuinfo.Controls.Add(this.txtCardNo);
            this.gbstuinfo.Controls.Add(this.label8);
            this.gbstuinfo.Controls.Add(this.dtpBirthday);
            this.gbstuinfo.Controls.Add(this.label7);
            this.gbstuinfo.Controls.Add(this.txtStudentIdNo);
            this.gbstuinfo.Controls.Add(this.label4);
            this.gbstuinfo.Location = new System.Drawing.Point(33, 264);
            this.gbstuinfo.Name = "gbstuinfo";
            this.gbstuinfo.Size = new System.Drawing.Size(942, 145);
            this.gbstuinfo.TabIndex = 13;
            this.gbstuinfo.TabStop = false;
            this.gbstuinfo.Text = "[学员基本信息]";
            // 
            // pbVideo
            // 
            this.pbVideo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbVideo.Location = new System.Drawing.Point(33, 72);
            this.pbVideo.Name = "pbVideo";
            this.pbVideo.Size = new System.Drawing.Size(195, 178);
            this.pbVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVideo.TabIndex = 11;
            this.pbVideo.TabStop = false;
            // 
            // btnStartVideo
            // 
            this.btnStartVideo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStartVideo.ImageIndex = 0;
            this.btnStartVideo.ImageList = this.imageList1;
            this.btnStartVideo.Location = new System.Drawing.Point(265, 74);
            this.btnStartVideo.Name = "btnStartVideo";
            this.btnStartVideo.Size = new System.Drawing.Size(103, 35);
            this.btnStartVideo.TabIndex = 14;
            this.btnStartVideo.Text = "启动摄像头 ";
            this.btnStartVideo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStartVideo.UseVisualStyleBackColor = true;
            this.btnStartVideo.Click += new System.EventHandler(this.btnStartVideo_Click);
            // 
            // btnTake
            // 
            this.btnTake.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTake.ImageIndex = 3;
            this.btnTake.ImageList = this.imageList1;
            this.btnTake.Location = new System.Drawing.Point(265, 146);
            this.btnTake.Name = "btnTake";
            this.btnTake.Size = new System.Drawing.Size(103, 35);
            this.btnTake.TabIndex = 14;
            this.btnTake.Text = "开始拍照 ";
            this.btnTake.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTake.UseVisualStyleBackColor = true;
            this.btnTake.Click += new System.EventHandler(this.btnTake_Click);
            // 
            // btnClear
            // 
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.ImageIndex = 4;
            this.btnClear.ImageList = this.imageList1;
            this.btnClear.Location = new System.Drawing.Point(374, 146);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(103, 35);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "清除照片 ";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCloseVideo
            // 
            this.btnCloseVideo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseVideo.ImageIndex = 1;
            this.btnCloseVideo.ImageList = this.imageList1;
            this.btnCloseVideo.Location = new System.Drawing.Point(374, 74);
            this.btnCloseVideo.Name = "btnCloseVideo";
            this.btnCloseVideo.Size = new System.Drawing.Size(103, 35);
            this.btnCloseVideo.TabIndex = 14;
            this.btnCloseVideo.Text = "关闭摄像头 ";
            this.btnCloseVideo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCloseVideo.UseVisualStyleBackColor = true;
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
            this.StudentId,
            this.StudentName,
            this.Gender,
            this.Birthday,
            this.CardNo,
            this.ClassName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudentList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStudentList.EnableHeadersVisualStyles = false;
            this.dgvStudentList.Location = new System.Drawing.Point(33, 430);
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
            this.dgvStudentList.Size = new System.Drawing.Size(942, 227);
            this.dgvStudentList.TabIndex = 99;
            // 
            // StudentId
            // 
            this.StudentId.DataPropertyName = "StudentId";
            this.StudentId.HeaderText = "学号";
            this.StudentId.Name = "StudentId";
            this.StudentId.ReadOnly = true;
            this.StudentId.Width = 150;
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
            // Birthday
            // 
            this.Birthday.DataPropertyName = "Birthday";
            this.Birthday.HeaderText = "出生日期";
            this.Birthday.Name = "Birthday";
            this.Birthday.ReadOnly = true;
            this.Birthday.Width = 150;
            // 
            // CardNo
            // 
            this.CardNo.DataPropertyName = "CardNo";
            this.CardNo.HeaderText = "考勤卡号";
            this.CardNo.Name = "CardNo";
            this.CardNo.ReadOnly = true;
            this.CardNo.Width = 150;
            // 
            // ClassName
            // 
            this.ClassName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClassName.DataPropertyName = "ClassName";
            this.ClassName.HeaderText = "所在班级";
            this.ClassName.Name = "ClassName";
            this.ClassName.ReadOnly = true;
            // 
            // FrmAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 669);
            this.Controls.Add(this.dgvStudentList);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCloseVideo);
            this.Controls.Add(this.btnTake);
            this.Controls.Add(this.btnStartVideo);
            this.Controls.Add(this.gbstuinfo);
            this.Controls.Add(this.btnChoseImage);
            this.Controls.Add(this.pbVideo);
            this.Controls.Add(this.pbStu);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label9);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmAddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加新学员";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmAddStudent_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbStu)).EndInit();
            this.gbstuinfo.ResumeLayout(false);
            this.gbstuinfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStudentIdNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboClassName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCardNo;
        private System.Windows.Forms.PictureBox pbStu;
        private System.Windows.Forms.Button btnChoseImage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbstuinfo;
        private System.Windows.Forms.PictureBox pbVideo;
        private System.Windows.Forms.Button btnStartVideo;
        private System.Windows.Forms.Button btnTake;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCloseVideo;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView dgvStudentList;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
    }
}