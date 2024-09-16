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
    public partial class Issuebook : Form
    {
        public Issuebook()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=desktop-m9csu4v;Initial Catalog=Addstudent;Integrated Security=True";
            {
                using (SqlConnection conn = new SqlConnection(connectionString)) // MySQLの場合は MySqlConnection を使用
                {
                    try
                    {
                        conn.Open();
                        string query = "INSERT INTO IssuedBooks (StudentId, EnrollmentNo, StudentName, StudentContact, StudentEmail, BookId, BookName, IssueDate) " +
                                       "VALUES (@StudentId, @EnrollmentNo, @StudentName, @StudentContact, @StudentEmail, @BookId, @BookName, @IssueDate)";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            // TextBox වල අගයන් SQL Command එකට එකතු කිරීම
                            cmd.Parameters.AddWithValue("@StudentId", txtstudentid.Text);
                            cmd.Parameters.AddWithValue("@EnrollmentNo", txtentroll.Text);
                            cmd.Parameters.AddWithValue("@StudentName", txtstudentname.Text);
                            cmd.Parameters.AddWithValue("@StudentContact", txtstudentcon.Text);
                            cmd.Parameters.AddWithValue("@StudentEmail", txtstudentemail.Text);
                            cmd.Parameters.AddWithValue("@BookId", txtbookid.Text);
                            cmd.Parameters.AddWithValue("@BookName", txtbookname.Text);
                            cmd.Parameters.AddWithValue("@IssueDate", dateTimePicker1.Value);

                            cmd.ExecuteNonQuery(); // SQL Command ක්‍රියාත්මක කිරීම
                            MessageBox.Show("Book Issued Successfully!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message); // වැරැදි පණිවිඩයක් පෙන්වීම
                    }
                }
            }
        }
    }
}
    

