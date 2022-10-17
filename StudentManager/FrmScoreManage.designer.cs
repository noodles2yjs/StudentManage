namespace StudentManager
{
    partial class FrmScoreManage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmScoreManage));
            this.dgvScoreList = new System.Windows.Forms.DataGridView();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbStat = new System.Windows.Forms.GroupBox();
            this.lblDBAvg = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblCSharpAvg = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAttendCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblList = new System.Windows.Forms.ListBox();
            this.btnStat = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSharp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SQLServerDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScoreList)).BeginInit();
            this.gbStat.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvScoreList
            // 
            this.dgvScoreList.AllowUserToAddRows = false;
            this.dgvScoreList.AllowUserToDeleteRows = false;
            this.dgvScoreList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvScoreList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvScoreList.ColumnHeadersHeight = 30;
            this.dgvScoreList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentId,
            this.StudentName,
            this.Gender,
            this.ClassName,
            this.CSharp,
            this.SQLServerDB});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvScoreList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvScoreList.Location = new System.Drawing.Point(19, 112);
            this.dgvScoreList.Name = "dgvScoreList";
            this.dgvScoreList.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvScoreList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvScoreList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvScoreList.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvScoreList.RowTemplate.Height = 23;
            this.dgvScoreList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvScoreList.Size = new System.Drawing.Size(767, 533);
            this.dgvScoreList.TabIndex = 7;
            this.dgvScoreList.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvScoreList_CurrentCellDirtyStateChanged);
            this.dgvScoreList.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvScoreList_RowPostPaint);
            // 
            // cboClass
            // 
            this.cboClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Location = new System.Drawing.Point(172, 72);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(181, 20);
            this.cboClass.TabIndex = 0;
            this.cboClass.SelectedIndexChanged += new System.EventHandler(this.cboClass_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "请选择要统计的班级：";
            // 
            // gbStat
            // 
            this.gbStat.Controls.Add(this.lblDBAvg);
            this.gbStat.Controls.Add(this.label8);
            this.gbStat.Controls.Add(this.lblCount);
            this.gbStat.Controls.Add(this.lblCSharpAvg);
            this.gbStat.Controls.Add(this.label4);
            this.gbStat.Controls.Add(this.label6);
            this.gbStat.Controls.Add(this.lblAttendCount);
            this.gbStat.Controls.Add(this.label3);
            this.gbStat.Location = new System.Drawing.Point(812, 112);
            this.gbStat.Name = "gbStat";
            this.gbStat.Size = new System.Drawing.Size(176, 214);
            this.gbStat.TabIndex = 10;
            this.gbStat.TabStop = false;
            this.gbStat.Text = "考试成绩统计";
            // 
            // lblDBAvg
            // 
            this.lblDBAvg.BackColor = System.Drawing.Color.White;
            this.lblDBAvg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDBAvg.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDBAvg.Location = new System.Drawing.Point(97, 172);
            this.lblDBAvg.Name = "lblDBAvg";
            this.lblDBAvg.Size = new System.Drawing.Size(61, 23);
            this.lblDBAvg.TabIndex = 12;
            this.lblDBAvg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "DB平均分：";
            // 
            // lblCount
            // 
            this.lblCount.BackColor = System.Drawing.Color.White;
            this.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCount.Location = new System.Drawing.Point(97, 79);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(61, 23);
            this.lblCount.TabIndex = 12;
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCSharpAvg
            // 
            this.lblCSharpAvg.BackColor = System.Drawing.Color.White;
            this.lblCSharpAvg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCSharpAvg.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCSharpAvg.Location = new System.Drawing.Point(97, 124);
            this.lblCSharpAvg.Name = "lblCSharpAvg";
            this.lblCSharpAvg.Size = new System.Drawing.Size(61, 23);
            this.lblCSharpAvg.TabIndex = 12;
            this.lblCSharpAvg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "缺考总人数：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "C#平均分：";
            // 
            // lblAttendCount
            // 
            this.lblAttendCount.BackColor = System.Drawing.Color.White;
            this.lblAttendCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAttendCount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAttendCount.Location = new System.Drawing.Point(97, 30);
            this.lblAttendCount.Name = "lblAttendCount";
            this.lblAttendCount.Size = new System.Drawing.Size(61, 23);
            this.lblAttendCount.TabIndex = 12;
            this.lblAttendCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "参考总人数：";
            // 
            // lblList
            // 
            this.lblList.FormattingEnabled = true;
            this.lblList.ItemHeight = 12;
            this.lblList.Location = new System.Drawing.Point(20, 24);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(138, 256);
            this.lblList.TabIndex = 13;
            // 
            // btnStat
            // 
            this.btnStat.Location = new System.Drawing.Point(619, 65);
            this.btnStat.Name = "btnStat";
            this.btnStat.Size = new System.Drawing.Size(167, 34);
            this.btnStat.TabIndex = 15;
            this.btnStat.Text = "统计全校考试信息";
            this.btnStat.UseVisualStyleBackColor = true;
            this.btnStat.Click += new System.EventHandler(this.btnStat_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.Purple;
            this.label9.Location = new System.Drawing.Point(19, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 31);
            this.label9.TabIndex = 16;
            this.label9.Text = "学员成绩管理";
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(896, 58);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(82, 34);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "关闭窗口";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblList);
            this.groupBox1.Location = new System.Drawing.Point(812, 335);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 310);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "缺考人员列表";
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
            this.ClassName.HeaderText = "班级";
            this.ClassName.Name = "ClassName";
            this.ClassName.ReadOnly = true;
            // 
            // CSharp
            // 
            this.CSharp.DataPropertyName = "CSharp";
            this.CSharp.HeaderText = "C#成绩";
            this.CSharp.Name = "CSharp";
            this.CSharp.ReadOnly = true;
            // 
            // SQLServerDB
            // 
            this.SQLServerDB.DataPropertyName = "SQLServerDB";
            this.SQLServerDB.HeaderText = "DB成绩";
            this.SQLServerDB.Name = "SQLServerDB";
            this.SQLServerDB.ReadOnly = true;
            // 
            // FrmScoreManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 669);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnStat);
            this.Controls.Add(this.gbStat);
            this.Controls.Add(this.dgvScoreList);
            this.Controls.Add(this.cboClass);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmScoreManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "成绩查询";
            ((System.ComponentModel.ISupportInitialize)(this.dgvScoreList)).EndInit();
            this.gbStat.ResumeLayout(false);
            this.gbStat.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvScoreList;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbStat;
        private System.Windows.Forms.Label lblAttendCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDBAvg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblCSharpAvg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lblList;
        private System.Windows.Forms.Button btnStat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSharp;
        private System.Windows.Forms.DataGridViewTextBoxColumn SQLServerDB;
    }
}