using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AMSF
{
    public partial class TeacherForm : Form
    {
        Database db = new Database();

        public TeacherForm()
        {
            InitializeComponent();
            LoadTeachers();
        }

        private void LoadTeachers()
        {
            dgvTeachers.DataSource = db.ExecuteSelect("SELECT * FROM Teachers");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlParameter[] p = new SqlParameter[]
            {
                new SqlParameter("@Name", txtName.Text),
                new SqlParameter("@Subject", txtSubject.Text)
            };

            if (db.ExecuteProcedure("sp_AddTeacher", p))
            {
                LoadTeachers();

                MessageBox.Show("Teacher added.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvTeachers.SelectedRows[0].Cells["TeacherID"].Value);

            SqlParameter[] p = new SqlParameter[]
            {
                new SqlParameter("@TeacherID", id),
                new SqlParameter("@Name", txtName.Text),
                new SqlParameter("@Subject", txtSubject.Text)
            };

            if (db.ExecuteProcedure("sp_UpdateTeacher", p))
            {
                LoadTeachers();

                MessageBox.Show("Teacher updated.");
            }
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTeachers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a teacher to delete.");
                return;
            }

            int id = Convert.ToInt32(dgvTeachers.SelectedRows[0].Cells["TeacherID"].Value);

            SqlParameter[] p = new SqlParameter[]
            {
        new SqlParameter("@TeacherID", id)
            };

            if (db.ExecuteProcedure("sp_DeleteTeacher", p))
            {
                LoadTeachers();
               
                MessageBox.Show("Teacher deleted.");
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtName.Clear();
            txtSubject.Clear();
        }


    }
}

