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
    public partial class UserBook : UserControl
    {

        public UserBook()
        {
            InitializeComponent();
        }
        public int Qty
        {
            get; set;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Qty++;
            btnOrder.Text = $"Ordered ({Qty})";
        }

        private void pic_Click(object sender, EventArgs e)
        {
           
        }
      

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserBook_Load(object sender, EventArgs e)
        {

        }

        private void btnRomove_Click(object sender, EventArgs e)
        {
            Qty--;
            if (Qty == 0)
            {
                btnOrder.Text = "Ordered";
                btnRomove.Visible=false;
            }
            btnOrder.Text = $"Ordered ({Qty})";
        }
    }
}
