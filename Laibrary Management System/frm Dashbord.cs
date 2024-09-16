using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laibrary_Management_System
{
    public partial class frm_Dashbord : Form
    {
        public frm_Dashbord()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Book_Registration f = new Book_Registration();
            f.Show();
            this.Hide();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Add_student ast = new Add_student();
            ast.Show();
        }

        private void btnissubook_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnissuebook_Click(object sender, EventArgs e)
        {
           Issuebook I = new Issuebook();
            I.Show();
        }

        private void btnreturnbook_Click(object sender, EventArgs e)
        {
            Returnbook R = new Returnbook();
            R.Show();
        }

        private void btnissuebook_Click_1(object sender, EventArgs e)
        {

        }
    }
}
