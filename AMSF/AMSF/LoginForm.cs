using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AMSF
{
    public partial class LoginForm : Form
    {
        Database db = new Database(); // Database connection class

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Query to check if admin exists
            string query = "SELECT COUNT(*) FROM Admin WHERE Username = @username AND Password = @password";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@username", username),
                new SqlParameter("@password", password)
            };

            DataTable result = db.ExecuteSelect(query, parameters);

            if (result.Rows.Count > 0 && Convert.ToInt32(result.Rows[0][0]) > 0)
            {
                DashboardForm dashboard = new DashboardForm();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
