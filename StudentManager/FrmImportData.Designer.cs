namespace StudentManager
{
    partial class FrmImportData
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImportData));
            this.dgvStudentList = new System.Windows.Forms.DataGridView();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentIdNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnChoseExcel = new System.Windows.Forms.Button();
            this.btnSaveToDB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudentList
            // 
            this.dgvStudentList.AllowUserToAddRows = false;
            this.dgvStudentList.AllowUserToDeleteRows = false;
            this.dgvStudentList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudentList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStudentList.ColumnHeadersHeight = 30;
            this.dgvStudentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentName,
            this.Gender,
            this.Birthday,
            this.Age,
            this.StudentIdNo,
            this.CardNo,
            this.PhoneNumber,
            this.StudentAddress,
            this.ClassId});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudentList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStudentList.Location = new System.Drawing.Point(19, 70);
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
            this.dgvStudentList.RowTemplate.Height = 30;
            this.dgvStudentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudentList.Size = new System.Drawing.Size(964, 592);
            this.dgvStudentList.TabIndex = 4;
            this.dgvStudentList.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvStudentList_RowPostPaint);
            // 
            // StudentName
            // 
            this.StudentName.DataPropertyName = "StudentName";
            this.StudentName.HeaderText = "姓名";
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "性别";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Width = 50;
            // 
            // Birthday
            // 
            this.Birthday.DataPropertyName = "Birthday";
            this.Birthday.HeaderText = "出生日期";
            this.Birthday.Name = "Birthday";
            this.Birthday.ReadOnly = true;
            // 
            // Age
            // 
            this.Age.DataPropertyName = "Age";
            this.Age.HeaderText = "年龄";
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            this.Age.Width = 50;
            // 
            // StudentIdNo
            // 
            this.StudentIdNo.DataPropertyName = "StudentIdNo";
            this.StudentIdNo.HeaderText = "身份证号";
            this.StudentIdNo.Name = "StudentIdNo";
            this.StudentIdNo.ReadOnly = true;
            this.StudentIdNo.Width = 150;
            // 
            // CardNo
            // 
            this.CardNo.DataPropertyName = "CardNo";
            this.CardNo.HeaderText = "考勤卡号";
            this.CardNo.Name = "CardNo";
            this.CardNo.ReadOnly = true;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.HeaderText = "电话号码";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            this.PhoneNumber.Width = 150;
            // 
            // StudentAddress
            // 
            this.StudentAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StudentAddress.DataPropertyName = "StudentAddress";
            this.StudentAddress.HeaderText = "家庭住址";
            this.StudentAddress.Name = "StudentAddress";
            this.StudentAddress.ReadOnly = true;
            // 
            // ClassId
            // 
            this.ClassId.DataPropertyName = "ClassId";
            this.ClassId.HeaderText = "班级";
            this.ClassId.Name = "ClassId";
            this.ClassId.ReadOnly = true;
            this.ClassId.Width = 50;
            // 
            // btnChoseExcel
            // 
            this.btnChoseExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnChoseExcel.Image")));
            this.btnChoseExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChoseExcel.Location = new System.Drawing.Point(19, 22);
            this.btnChoseExcel.Name = "btnChoseExcel";
            this.btnChoseExcel.Size = new System.Drawing.Size(178, 34);
            this.btnChoseExcel.TabIndex = 16;
            this.btnChoseExcel.Text = "从外部Excel文件导入数据 ";
            this.btnChoseExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChoseExcel.UseVisualStyleBackColor = true;
            this.btnChoseExcel.Click += new System.EventHandler(this.btnChoseExcel_Click);
            // 
            // btnSaveToDB
            // 
            this.btnSaveToDB.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveToDB.Image")));
            this.btnSaveToDB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveToDB.Location = new System.Drawing.Point(213, 22);
            this.btnSaveToDB.Name = "btnSaveToDB";
            this.btnSaveToDB.Size = new System.Drawing.Size(115, 34);
            this.btnSaveToDB.TabIndex = 17;
            this.btnSaveToDB.Text = "保存到数据库 ";
            this.btnSaveToDB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveToDB.UseVisualStyleBackColor = true;
            this.btnSaveToDB.Click += new System.EventHandler(this.btnSaveToDB_Click);
            // 
            // FrmImportData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 683);
            this.Controls.Add(this.btnSaveToDB);
            this.Controls.Add(this.btnChoseExcel);
            this.Controls.Add(this.dgvStudentList);
            this.MaximizeBox = false;
            this.Name = "FrmImportData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[批量导入学员信息]";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudentList;
        private System.Windows.Forms.Button btnChoseExcel;
        private System.Windows.Forms.Button btnSaveToDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentIdNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassId;
    }
}