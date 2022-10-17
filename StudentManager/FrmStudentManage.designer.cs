namespace StudentManager
{
    partial class FrmStudentManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStudentManage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.dgvStudentList = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiModifyStu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmidDeleteStu = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnQueryById = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEidt = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnNameDESC = new System.Windows.Forms.Button();
            this.btnStuIdDESC = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentIdNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "学员班级：";
            // 
            // cboClass
            // 
            this.cboClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Location = new System.Drawing.Point(84, 30);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(117, 20);
            this.cboClass.TabIndex = 1;
            // 
            // btnQuery
            // 
            this.btnQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnQuery.Image")));
            this.btnQuery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuery.Location = new System.Drawing.Point(218, 23);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(84, 35);
            this.btnQuery.TabIndex = 2;
            this.btnQuery.Text = "提交查询";
            this.btnQuery.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // dgvStudentList
            // 
            this.dgvStudentList.AllowUserToAddRows = false;
            this.dgvStudentList.AllowUserToDeleteRows = false;
            this.dgvStudentList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudentList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvStudentList.ColumnHeadersHeight = 30;
            this.dgvStudentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentId,
            this.StudentName,
            this.Gender,
            this.StudentIdNo,
            this.Birthday,
            this.PhoneNumber,
            this.ClassName});
            this.dgvStudentList.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudentList.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvStudentList.Location = new System.Drawing.Point(22, 224);
            this.dgvStudentList.Name = "dgvStudentList";
            this.dgvStudentList.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudentList.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvStudentList.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvStudentList.RowTemplate.Height = 23;
            this.dgvStudentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudentList.Size = new System.Drawing.Size(967, 433);
            this.dgvStudentList.TabIndex = 3;
            this.dgvStudentList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudentList_CellDoubleClick);
            this.dgvStudentList.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvStudentList_RowPostPaint);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiModifyStu,
            this.tsmidDeleteStu});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(145, 48);
            // 
            // tsmiModifyStu
            // 
            this.tsmiModifyStu.Name = "tsmiModifyStu";
            this.tsmiModifyStu.Size = new System.Drawing.Size(144, 22);
            this.tsmiModifyStu.Text = "修改学员(&M)";
            // 
            // tsmidDeleteStu
            // 
            this.tsmidDeleteStu.Name = "tsmidDeleteStu";
            this.tsmidDeleteStu.Size = new System.Drawing.Size(144, 22);
            this.tsmidDeleteStu.Text = "删除学员(&D)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtStudentId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnQueryById);
            this.groupBox1.Location = new System.Drawing.Point(22, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 61);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "按学号精确查询";
            // 
            // txtStudentId
            // 
            this.txtStudentId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudentId.Location = new System.Drawing.Point(84, 25);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(117, 21);
            this.txtStudentId.TabIndex = 1;
            this.txtStudentId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStudentId_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "输入学号：";
            // 
            // btnQueryById
            // 
            this.btnQueryById.Location = new System.Drawing.Point(218, 17);
            this.btnQueryById.Name = "btnQueryById";
            this.btnQueryById.Size = new System.Drawing.Size(84, 35);
            this.btnQueryById.TabIndex = 2;
            this.btnQueryById.Text = "提交查询";
            this.btnQueryById.UseVisualStyleBackColor = true;
            this.btnQueryById.Click += new System.EventHandler(this.btnQueryById_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(895, 164);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 35);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "关闭窗口";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEidt
            // 
            this.btnEidt.Image = ((System.Drawing.Image)(resources.GetObject("btnEidt.Image")));
            this.btnEidt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEidt.Location = new System.Drawing.Point(519, 22);
            this.btnEidt.Name = "btnEidt";
            this.btnEidt.Size = new System.Drawing.Size(75, 35);
            this.btnEidt.TabIndex = 2;
            this.btnEidt.Text = "修  改";
            this.btnEidt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEidt.UseVisualStyleBackColor = true;
            this.btnEidt.Click += new System.EventHandler(this.btnEidt_Click);
            // 
            // btnDel
            // 
            this.btnDel.ForeColor = System.Drawing.Color.Red;
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDel.Location = new System.Drawing.Point(600, 22);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 35);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "删  除";
            this.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnNameDESC
            // 
            this.btnNameDESC.Image = ((System.Drawing.Image)(resources.GetObject("btnNameDESC.Image")));
            this.btnNameDESC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNameDESC.Location = new System.Drawing.Point(324, 23);
            this.btnNameDESC.Name = "btnNameDESC";
            this.btnNameDESC.Size = new System.Drawing.Size(84, 35);
            this.btnNameDESC.TabIndex = 5;
            this.btnNameDESC.Text = "姓名降序";
            this.btnNameDESC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNameDESC.UseVisualStyleBackColor = true;
            this.btnNameDESC.Click += new System.EventHandler(this.btnNameDESC_Click);
            // 
            // btnStuIdDESC
            // 
            this.btnStuIdDESC.Image = ((System.Drawing.Image)(resources.GetObject("btnStuIdDESC.Image")));
            this.btnStuIdDESC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStuIdDESC.Location = new System.Drawing.Point(414, 23);
            this.btnStuIdDESC.Name = "btnStuIdDESC";
            this.btnStuIdDESC.Size = new System.Drawing.Size(84, 35);
            this.btnStuIdDESC.TabIndex = 5;
            this.btnStuIdDESC.Text = "学号降序";
            this.btnStuIdDESC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStuIdDESC.UseVisualStyleBackColor = true;
            this.btnStuIdDESC.Click += new System.EventHandler(this.btnStuIdDESC_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(812, 22);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(136, 35);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "打印当前学员信息 ";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnStuIdDESC);
            this.groupBox2.Controls.Add(this.cboClass);
            this.groupBox2.Controls.Add(this.btnQuery);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnPrint);
            this.groupBox2.Controls.Add(this.btnExport);
            this.groupBox2.Controls.Add(this.btnNameDESC);
            this.groupBox2.Controls.Add(this.btnDel);
            this.groupBox2.Controls.Add(this.btnEidt);
            this.groupBox2.Location = new System.Drawing.Point(22, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(967, 71);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "[按照班级查询]";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.Purple;
            this.label9.Location = new System.Drawing.Point(16, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 31);
            this.label9.TabIndex = 3;
            this.label9.Text = "学员信息管理";
            // 
            // btnExport
            // 
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(698, 22);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(108, 35);
            this.btnExport.TabIndex = 6;
            this.btnExport.Text = "导出到Excel ";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // StudentId
            // 
            this.StudentId.DataPropertyName = "StudentId";
            this.StudentId.Frozen = true;
            this.StudentId.HeaderText = "学号";
            this.StudentId.Name = "StudentId";
            this.StudentId.ReadOnly = true;
            // 
            // StudentName
            // 
            this.StudentName.DataPropertyName = "StudentName";
            this.StudentName.HeaderText = "姓名";
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            this.StudentName.Width = 120;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "性别";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Width = 80;
            // 
            // StudentIdNo
            // 
            this.StudentIdNo.DataPropertyName = "StudentIdNo";
            this.StudentIdNo.HeaderText = "身份证号";
            this.StudentIdNo.Name = "StudentIdNo";
            this.StudentIdNo.ReadOnly = true;
            this.StudentIdNo.Width = 200;
            // 
            // Birthday
            // 
            this.Birthday.DataPropertyName = "Birthday";
            this.Birthday.HeaderText = "出生日期";
            this.Birthday.Name = "Birthday";
            this.Birthday.ReadOnly = true;
            this.Birthday.Width = 120;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.HeaderText = "手机号码";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            this.PhoneNumber.Width = 150;
            // 
            // ClassName
            // 
            this.ClassName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClassName.DataPropertyName = "ClassName";
            this.ClassName.HeaderText = "所在班级";
            this.ClassName.Name = "ClassName";
            this.ClassName.ReadOnly = true;
            // 
            // FrmStudentManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 669);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvStudentList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmStudentManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学员信息管理";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.DataGridView dgvStudentList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnQueryById;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEidt;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiModifyStu;
        private System.Windows.Forms.ToolStripMenuItem tsmidDeleteStu;
        private System.Windows.Forms.Button btnNameDESC;
        private System.Windows.Forms.Button btnStuIdDESC;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentIdNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
    }
}