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
    public partial class StudentForm : Form
    {
        Database db = new Database();

        public StudentForm()
        {
            InitializeComponent();
            LoadStudents();
        }

        private void LoadStudents()
        {
            dgvStudents.DataSource = db.ExecuteSelect("SELECT * FROM Students");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlParameter[] p = new SqlParameter[]
            {
                new SqlParameter("@Name", txtName.Text),
                new SqlParameter("@RollNo", txtRollNo.Text),
                new SqlParameter("@Department", txtDept.Text)
            };

            if (db.ExecuteProcedure("sp_AddStudent", p))
            {
                LoadStudents();
                ClearFields();
                MessageBox.Show("Student added.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvStudents.SelectedRows[0].Cells["StudentID"].Value);

            SqlParameter[] p = new SqlParameter[]
            {
                new SqlParameter("@StudentID", id),
                new SqlParameter("@Name", txtName.Text),
                new SqlParameter("@RollNo", txtRollNo.Text),
                new SqlParameter("@Department", txtDept.Text)
            };

            if (db.ExecuteProcedure("sp_UpdateStudent", p))
            {
                LoadStudents();
                ClearFields();
                MessageBox.Show("Student updated.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvStudents.SelectedRows[0].Cells["StudentID"].Value);

            SqlParameter[] p = new SqlParameter[]
            {
                new SqlParameter("@StudentID", id)
            };

            if (db.ExecuteProcedure("sp_DeleteStudent", p))
            {
                LoadStudents();
                ClearFields();
                MessageBox.Show("Student deleted.");
            }
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStudents.Rows[e.RowIndex];
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtRollNo.Text = row.Cells["RollNo"].Value.ToString();
                txtDept.Text = row.Cells["Department"].Value.ToString();
            }
        }

        private void ClearFields()
        {
            txtName.Clear();
            txtRollNo.Clear();
            txtDept.Clear();
        }

        
    }
}
