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

namespace Laibrary_Management_System
{
    public partial class Add_student : Form
    {
        public Add_student()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                // Define your SQL Server connection string
                string connectionString = "Data Source=desktop-m9csu4v;Initial Catalog=Addstudent;Integrated Security=True";

                // SQL Query to insert data into StudentInfo table
                string query = "INSERT INTO StudentInfo (StudentName, EnrollmentNo, DepartmentName, StudentContact, StudentEmail, StudentSemester) " +
                               "VALUES (@StudentName, @EnrollmentNo, @DepartmentName, @StudentContact, @StudentEmail, @StudentSemester)";

                // Create SQL Connection
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Create SQL Command
                    SqlCommand command = new SqlCommand(query, connection);

                    // Adding values from the textboxes into the SQL parameters
                    command.Parameters.AddWithValue("@StudentName", txtstudentname.Text);
                    command.Parameters.AddWithValue("@EnrollmentNo", txtEntroll.Text);
                    command.Parameters.AddWithValue("@DepartmentName", txtDepart.Text);
                    command.Parameters.AddWithValue("@StudentContact", txtstudentcon.Text);
                    command.Parameters.AddWithValue("@StudentEmail", txtstudentemail.Text);
                    command.Parameters.AddWithValue("@StudentSemester", txtstudentsem.Text);

                    // Open connection, execute query and close the connection
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    // Check if data was successfully inserted
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Student added successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Error adding student.");
                    }
                }
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            new frm_Dashbord().Show();
            this.Hide();
        }

        private void Add_student_Load(object sender, EventArgs e)
        {

        }
    }
}
