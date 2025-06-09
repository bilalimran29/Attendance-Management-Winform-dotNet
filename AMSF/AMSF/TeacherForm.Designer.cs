namespace AMSF
{
    partial class TeacherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherForm));
            this.lblTeacherName = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.btnUpdateTeacher = new System.Windows.Forms.Button();
            this.btnDeleteTeacher = new System.Windows.Forms.Button();
            this.btnClearTeacher = new System.Windows.Forms.Button();
            this.dgvTeachers = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTeacherName
            // 
            this.lblTeacherName.AutoSize = true;
            this.lblTeacherName.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblTeacherName.Location = new System.Drawing.Point(264, 47);
            this.lblTeacherName.Name = "lblTeacherName";
            this.lblTeacherName.Size = new System.Drawing.Size(70, 23);
            this.lblTeacherName.TabIndex = 0;
            this.lblTeacherName.Text = "Name : ";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblSubject.Location = new System.Drawing.Point(254, 107);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(80, 23);
            this.lblSubject.TabIndex = 1;
            this.lblSubject.Text = "Subject : ";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtName.Location = new System.Drawing.Point(360, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(206, 30);
            this.txtName.TabIndex = 2;
            // 
            // txtSubject
            // 
            this.txtSubject.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtSubject.Location = new System.Drawing.Point(360, 104);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(206, 30);
            this.txtSubject.TabIndex = 3;
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnAddTeacher.Location = new System.Drawing.Point(123, 188);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(75, 32);
            this.btnAddTeacher.TabIndex = 4;
            this.btnAddTeacher.Text = "Add";
            this.btnAddTeacher.UseVisualStyleBackColor = true;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdateTeacher
            // 
            this.btnUpdateTeacher.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnUpdateTeacher.Location = new System.Drawing.Point(302, 188);
            this.btnUpdateTeacher.Name = "btnUpdateTeacher";
            this.btnUpdateTeacher.Size = new System.Drawing.Size(75, 32);
            this.btnUpdateTeacher.TabIndex = 5;
            this.btnUpdateTeacher.Text = "Update";
            this.btnUpdateTeacher.UseVisualStyleBackColor = true;
            this.btnUpdateTeacher.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDeleteTeacher
            // 
            this.btnDeleteTeacher.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnDeleteTeacher.Location = new System.Drawing.Point(506, 191);
            this.btnDeleteTeacher.Name = "btnDeleteTeacher";
            this.btnDeleteTeacher.Size = new System.Drawing.Size(75, 29);
            this.btnDeleteTeacher.TabIndex = 6;
            this.btnDeleteTeacher.Text = "Delete";
            this.btnDeleteTeacher.UseVisualStyleBackColor = true;
            this.btnDeleteTeacher.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClearTeacher
            // 
            this.btnClearTeacher.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnClearTeacher.Location = new System.Drawing.Point(674, 191);
            this.btnClearTeacher.Name = "btnClearTeacher";
            this.btnClearTeacher.Size = new System.Drawing.Size(75, 29);
            this.btnClearTeacher.TabIndex = 7;
            this.btnClearTeacher.Text = "Clear";
            this.btnClearTeacher.UseVisualStyleBackColor = true;
            this.btnClearTeacher.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvTeachers
            // 
            this.dgvTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeachers.Location = new System.Drawing.Point(-1, 277);
            this.dgvTeachers.Name = "dgvTeachers";
            this.dgvTeachers.ReadOnly = true;
            this.dgvTeachers.RowHeadersWidth = 51;
            this.dgvTeachers.RowTemplate.Height = 24;
            this.dgvTeachers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTeachers.Size = new System.Drawing.Size(803, 174);
            this.dgvTeachers.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 109);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvTeachers);
            this.Controls.Add(this.btnClearTeacher);
            this.Controls.Add(this.btnDeleteTeacher);
            this.Controls.Add(this.btnUpdateTeacher);
            this.Controls.Add(this.btnAddTeacher);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblTeacherName);
            this.Name = "TeacherForm";
            this.Text = "TeacherForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTeacherName;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Button btnAddTeacher;
        private System.Windows.Forms.Button btnUpdateTeacher;
        private System.Windows.Forms.Button btnDeleteTeacher;
        private System.Windows.Forms.Button btnClearTeacher;
        private System.Windows.Forms.DataGridView dgvTeachers;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
