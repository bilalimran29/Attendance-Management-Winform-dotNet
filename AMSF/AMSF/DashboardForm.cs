using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AMSF
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            StudentForm sf = new StudentForm();
            sf.Show();
        }

        private void btnTeachers_Click(object sender, EventArgs e)
        {
            TeacherForm tf = new TeacherForm();
            tf.Show();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            AttendanceForm af = new AttendanceForm();
            af.Show();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ViewAttendanceForm vaf = new ViewAttendanceForm();
            vaf.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Close();
        }
    }
}

