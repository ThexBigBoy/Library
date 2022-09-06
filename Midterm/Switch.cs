using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm
{
    public partial class Switch : Form
    {
        public Switch()
        {
            InitializeComponent();
        }

        private void buy_Click(object sender, EventArgs e)
        {
            this.Hide();
            book Book = new book();
            Book.Show();

        }

        private void borrow_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDashboard das = new frmDashboard();
            das.Show();
        }
    }
}
