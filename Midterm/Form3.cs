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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmDashboard db = new frmDashboard();
            this.Close();
            db.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name, position, contact;
            string gender = "";
            name = txtName.Text;
            if (radMale.Checked)
                gender = "Male";
            if (radFemale.Checked)
                gender = "Female";
            position = cbPosition.Text;
            contact = txtContact.Text;

            string[] info = { name, gender, position, contact };
            ListViewItem item = new ListViewItem(info);
            lstView.Items.Add(item);

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int i = lstView.SelectedIndices[0];
            lstView.Items.RemoveAt(i);
        }
    }
}
