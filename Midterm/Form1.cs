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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string name, pass;
            name = tbName.Text;
            pass = tbPassword.Text;

            if (name == "Dara")
            {
                if (pass == "1234")
                {
                    frmDashboard frmDashboard = new frmDashboard();
                    frmDashboard dash = frmDashboard;
                    this.Hide();
                    dash.Show();
                }
                else
                    MessageBox.Show("Invalid Password.");
            }
            else
                MessageBox.Show("Invalid Name.");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
    }
}
