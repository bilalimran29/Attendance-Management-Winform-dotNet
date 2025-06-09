namespace AMSF
{
    partial class ViewAttendanceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAttendanceForm));
            this.lblDateSelect = new System.Windows.Forms.Label();
            this.dtpAttendanceDate = new System.Windows.Forms.DateTimePicker();
            this.btnLoadAttendance = new System.Windows.Forms.Button();
            this.dgvAttendancee = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendancee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDateSelect
            // 
            this.lblDateSelect.AutoSize = true;
            this.lblDateSelect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDateSelect.Location = new System.Drawing.Point(328, 45);
            this.lblDateSelect.Name = "lblDateSelect";
            this.lblDateSelect.Size = new System.Drawing.Size(137, 28);
            this.lblDateSelect.TabIndex = 0;
            this.lblDateSelect.Text = "Select Date : ";
            // 
            // dtpAttendanceDate
            // 
            this.dtpAttendanceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAttendanceDate.Location = new System.Drawing.Point(456, 51);
            this.dtpAttendanceDate.Name = "dtpAttendanceDate";
            this.dtpAttendanceDate.Size = new System.Drawing.Size(200, 22);
            this.dtpAttendanceDate.TabIndex = 1;
            // 
            // btnLoadAttendance
            // 
            this.btnLoadAttendance.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnLoadAttendance.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.btnLoadAttendance.Location = new System.Drawing.Point(456, 151);
            this.btnLoadAttendance.Name = "btnLoadAttendance";
            this.btnLoadAttendance.Size = new System.Drawing.Size(172, 41);
            this.btnLoadAttendance.TabIndex = 2;
            this.btnLoadAttendance.Text = "Load Attendance";
            this.btnLoadAttendance.UseVisualStyleBackColor = false;
            this.btnLoadAttendance.Click += new System.EventHandler(this.btnLoadAttendance_Click);
            // 
            // dgvAttendancee
            // 
            this.dgvAttendancee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendancee.Location = new System.Drawing.Point(-1, 236);
            this.dgvAttendancee.Name = "dgvAttendancee";
            this.dgvAttendancee.ReadOnly = true;
            this.dgvAttendancee.RowHeadersWidth = 51;
            this.dgvAttendancee.RowTemplate.Height = 24;
            this.dgvAttendancee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAttendancee.Size = new System.Drawing.Size(799, 217);
            this.dgvAttendancee.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 238);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(662, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(136, 229);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // ViewAttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvAttendancee);
            this.Controls.Add(this.btnLoadAttendance);
            this.Controls.Add(this.dtpAttendanceDate);
            this.Controls.Add(this.lblDateSelect);
            this.Name = "ViewAttendanceForm";
            this.Text = "View Attendance";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendancee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDateSelect;
        private System.Windows.Forms.DateTimePicker dtpAttendanceDate;
        private System.Windows.Forms.Button btnLoadAttendance;
        private System.Windows.Forms.DataGridView dgvAttendancee;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
