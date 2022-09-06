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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void lsvAbout_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmDashboard db = new frmDashboard();
            this.Close();
            db.Show();

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name, group, title;
            string gender = "";
            name = txtName.Text;
            if (radMale.Checked)
                gender = "Male";
            if (radFemale.Checked)
                gender = "Female";
            group = txtGroup.Text;
            title = txtTitle.Text;
            string info = name + "\t" + "\t" + "\t" + "\t" + gender + "\t" + "\t" + "\t" + "\t" + group + "\t" + "\t" + "\t" + "\t" + title;
            //listbox
            lstList.Items.Add(info);
        }

        private void btnRemove_Click_1(object sender, EventArgs e)
        {
            lstList.Items.Remove(lstList.SelectedItem);
        }

        private void lstList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
