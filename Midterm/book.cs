using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm
{
    public partial class book : Form
    {
        public book()
        {
            InitializeComponent();
            string[] filenames = Directory.GetFiles("D:\\Pic");
            Random ran = new Random();

            int col = 1, row = 0;
            foreach (string fname in filenames)
            {
                Image im = Image.FromFile(fname);
                UserBook userb=new UserBook();
                userb.Pic = im;
                userb.Descr = Path.GetFileNameWithoutExtension(fname);
                int price = ran.Next(5) + 1;
                userb.Price=price.ToString("C2");
                frmtableLayoutPanel1.Controls.Add(userb, col, row);
                col++;
                if (col>4)
                {
                    col = 1; row++;
                }
                

            }
            
        }

        private void swi1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmDashboard dash =new frmDashboard();
            dash.Show();
            this.Close();
        }
    }
}
