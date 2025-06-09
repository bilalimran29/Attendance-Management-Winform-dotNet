using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AMSF
{
    public partial class AttendanceForm : Form
    {
        Database db = new Database();

        public AttendanceForm()
        {
            InitializeComponent();
            LoadStudentIDs();
            LoadTeacherIDs();
            LoadAttendanceRecords();
            cmbStatus.Items.AddRange(new string[] { "Present", "Absent" });
            cmbStatus.SelectedIndex = 0;
            dtpAttendanceDate.Value = DateTime.Today;
        }

        private void LoadStudentIDs()
        {
            DataTable dt = db.ExecuteSelect("SELECT StudentID FROM Students");
            cmbStudentID.DataSource = dt;
            cmbStudentID.DisplayMember = "StudentID";
            cmbStudentID.ValueMember = "StudentID";
        }

        private void LoadTeacherIDs()
        {
            DataTable dt = db.ExecuteSelect("SELECT TeacherID FROM Teachers");
            cmbTeacherID.DataSource = dt;
            cmbTeacherID.DisplayMember = "TeacherID";
            cmbTeacherID.ValueMember = "TeacherID";
        }

        private void LoadAttendanceRecords()
        {
            string query = @"
                SELECT A.AttendanceID, A.StudentID, A.TeacherID, A.AttendanceDate, A.Status
                FROM Attendance A
                ORDER BY A.AttendanceDate DESC";
            dgvAttendance.DataSource = db.ExecuteSelect(query);
        }

        private void btnMark_Click(object sender, EventArgs e)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@StudentID", cmbStudentID.SelectedValue),
                new SqlParameter("@TeacherID", cmbTeacherID.SelectedValue),
                new SqlParameter("@Date", dtpAttendanceDate.Value.Date),
                new SqlParameter("@Status", cmbStatus.SelectedItem.ToString())
            };

            bool success = db.ExecuteProcedure("sp_MarkAttendance", parameters);

            if (success)
            {
                MessageBox.Show("Attendance marked successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAttendanceRecords();
            }
            else
            {
                MessageBox.Show("Attendance already marked or error occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}

