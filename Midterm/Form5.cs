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
    public partial class Form5 : Form
    {
        public Form5()
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

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DataGridViewRow row;
            row = dataGridView1.CurrentRow;
            dataGridView1.Rows.Remove(row);
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row;
            row = dataGridView1.CurrentRow;
            txtName.Text = row.Cells[0].Value + "";
            cbGender.Text = row.Cells[1].Value + "";
            txtGroup.Text = row.Cells[2].Value + "";
            txtTitle.Text = row.Cells[3].Value + "";


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name, gender, group, title;
            name = txtName.Text;
            gender = cbGender.Text;
            group = txtGroup.Text;
            title = txtTitle.Text;

            string[] info = { name, gender, group, title };
            dataGridView1.Rows.Add(info);
                
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            DataGridViewRow row;
            row = dataGridView1.CurrentRow;
            row.Cells[0].Value = txtName.Text;
            row.Cells[1].Value = cbGender.Text;
            row.Cells[2].Value = txtGroup.Text;
            row.Cells[3].Value = txtTitle.Text;
        }
    }
}
