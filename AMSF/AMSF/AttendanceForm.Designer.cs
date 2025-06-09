namespace AMSF
{
    partial class AttendanceForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendanceForm));
            this.lblSelectStudent = new System.Windows.Forms.Label();
            this.lblSelectTeacher = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.cmbStudentID = new System.Windows.Forms.ComboBox();
            this.cmbTeacherID = new System.Windows.Forms.ComboBox();
            this.dtpAttendanceDate = new System.Windows.Forms.DateTimePicker();
            this.btnMark = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.dgvAttendance = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelectStudent
            // 
            this.lblSelectStudent.AutoSize = true;
            this.lblSelectStudent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSelectStudent.Location = new System.Drawing.Point(343, 9);
            this.lblSelectStudent.Name = "lblSelectStudent";
            this.lblSelectStudent.Size = new System.Drawing.Size(166, 28);
            this.lblSelectStudent.TabIndex = 0;
            this.lblSelectStudent.Text = "Select Student : ";
            // 
            // lblSelectTeacher
            // 
            this.lblSelectTeacher.AutoSize = true;
            this.lblSelectTeacher.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSelectTeacher.Location = new System.Drawing.Point(343, 52);
            this.lblSelectTeacher.Name = "lblSelectTeacher";
            this.lblSelectTeacher.Size = new System.Drawing.Size(174, 28);
            this.lblSelectTeacher.TabIndex = 1;
            this.lblSelectTeacher.Text = "Select Teachers : ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDate.Location = new System.Drawing.Point(443, 92);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(74, 28);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date : ";
            // 
            // cmbStudentID
            // 
            this.cmbStudentID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStudentID.FormattingEnabled = true;
            this.cmbStudentID.Location = new System.Drawing.Point(515, 13);
            this.cmbStudentID.Name = "cmbStudentID";
            this.cmbStudentID.Size = new System.Drawing.Size(159, 24);
            this.cmbStudentID.TabIndex = 3;
            // 
            // cmbTeacherID
            // 
            this.cmbTeacherID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeacherID.FormattingEnabled = true;
            this.cmbTeacherID.Location = new System.Drawing.Point(515, 59);
            this.cmbTeacherID.Name = "cmbTeacherID";
            this.cmbTeacherID.Size = new System.Drawing.Size(159, 24);
            this.cmbTeacherID.TabIndex = 4;
            // 
            // dtpAttendanceDate
            // 
            this.dtpAttendanceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAttendanceDate.Location = new System.Drawing.Point(515, 98);
            this.dtpAttendanceDate.Name = "dtpAttendanceDate";
            this.dtpAttendanceDate.Size = new System.Drawing.Size(200, 22);
            this.dtpAttendanceDate.TabIndex = 5;
            // 
            // btnMark
            // 
            this.btnMark.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnMark.Location = new System.Drawing.Point(559, 191);
            this.btnMark.Name = "btnMark";
            this.btnMark.Size = new System.Drawing.Size(137, 38);
            this.btnMark.TabIndex = 6;
            this.btnMark.Text = "Mark Attendance";
            this.btnMark.UseVisualStyleBackColor = true;
            this.btnMark.Click += new System.EventHandler(this.btnMark_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblStatus.Location = new System.Drawing.Point(429, 135);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(88, 28);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Status : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(349, 448);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(699, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 80);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Present",
            "Absent"});
            this.cmbStatus.Location = new System.Drawing.Point(516, 139);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(199, 24);
            this.cmbStatus.TabIndex = 11;
            // 
            // dgvAttendance
            // 
            this.dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendance.Location = new System.Drawing.Point(348, 256);
            this.dgvAttendance.Name = "dgvAttendance";
            this.dgvAttendance.ReadOnly = true;
            this.dgvAttendance.RowHeadersWidth = 51;
            this.dgvAttendance.RowTemplate.Height = 24;
            this.dgvAttendance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAttendance.Size = new System.Drawing.Size(451, 192);
            this.dgvAttendance.TabIndex = 12;
            // 
            // AttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvAttendance);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnMark);
            this.Controls.Add(this.dtpAttendanceDate);
            this.Controls.Add(this.cmbTeacherID);
            this.Controls.Add(this.cmbStudentID);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblSelectTeacher);
            this.Controls.Add(this.lblSelectStudent);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "AttendanceForm";
            this.Text = "AttendanceForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectStudent;
        private System.Windows.Forms.Label lblSelectTeacher;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cmbStudentID;
        private System.Windows.Forms.ComboBox cmbTeacherID;
        private System.Windows.Forms.DateTimePicker dtpAttendanceDate;
        private System.Windows.Forms.Button btnMark;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.DataGridView dgvAttendance;
    }
}
