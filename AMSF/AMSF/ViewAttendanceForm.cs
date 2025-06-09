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
    public partial class ViewAttendanceForm : Form
    {
        Database db = new Database();

        public ViewAttendanceForm()
        {
            InitializeComponent();
        }

        private void btnLoadAttendance_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpAttendanceDate.Value.Date;

            string query = @"
                SELECT AttendanceID, StudentID, TeacherID, AttendanceDate, Status
                FROM Attendance
                WHERE AttendanceDate = @Date
                ORDER BY StudentID";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Date", selectedDate)
            };

            DataTable dt = db.ExecuteSelect(query, parameters);
            dgvAttendancee.DataSource = dt;
        }

        
    }
}
