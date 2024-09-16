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
using System.Xml.Linq;

namespace Laibrary_Management_System
{
    public partial class Book_Registration : Form
    {
        public Book_Registration()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

      
        string classification;
        
        private void btnregister_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=desktop-m9csu4v;Initial Catalog=Libraryregister;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query = "INSERT INTO Books (BookId, BookTitle, BookName, BookAuthor, NoOfPages, StudentName, Classification) " +
               "VALUES (@BookId, @BookTitle, @BookName, @BookAuthor, @NoOfPages, @StudentName, @Classification)";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.AddWithValue("@BookId", txtBookid.Text);
            cmd.Parameters.AddWithValue("@BookTitle", txtBooktitel.Text);
            cmd.Parameters.AddWithValue("@BookName", txtBookname.Text);
            cmd.Parameters.AddWithValue("@BookAuthor", txtauthor.Text);
            cmd.Parameters.AddWithValue("@NoOfPages", txtpages.Text);
            cmd.Parameters.AddWithValue("@StudentName", txtstudentname.Text);
            cmd.Parameters.AddWithValue("@Classification", (rdbref.Checked) ? "Reference" : "Borrowable");

            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Book Registered Succsess...");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            frm_Dashbord dashboard = new frm_Dashbord();
            dashboard.Show();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            new frm_Dashbord().Show();
            this.Hide();
        }
    }
}
