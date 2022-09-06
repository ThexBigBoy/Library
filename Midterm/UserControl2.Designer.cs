using System.Drawing;

namespace Midterm
{
    partial class UserBook
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserBook));
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnRomove = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDescr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // picPhoto
            // 
            this.picPhoto.Image = ((System.Drawing.Image)(resources.GetObject("picPhoto.Image")));
            this.picPhoto.Location = new System.Drawing.Point(9, 8);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(238, 254);
            this.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picPhoto.TabIndex = 0;
            this.picPhoto.TabStop = false;
            this.picPhoto.Click += new System.EventHandler(this.pic_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(8, 333);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(101, 30);
            this.btnOrder.TabIndex = 1;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnRomove
            // 
            this.btnRomove.Location = new System.Drawing.Point(143, 333);
            this.btnRomove.Name = "btnRomove";
            this.btnRomove.Size = new System.Drawing.Size(101, 30);
            this.btnRomove.TabIndex = 2;
            this.btnRomove.Text = "Remove";
            this.btnRomove.UseVisualStyleBackColor = true;
            this.btnRomove.Click += new System.EventHandler(this.btnRomove_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(97, 270);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(141, 20);
            this.txtPrice.TabIndex = 3;
            // 
            // txtDescr
            // 
            this.txtDescr.Location = new System.Drawing.Point(97, 296);
            this.txtDescr.Name = "txtDescr";
            this.txtDescr.Size = new System.Drawing.Size(141, 20);
            this.txtDescr.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Description:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Price:";
            // 
            // UserBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescr);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.btnRomove);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.picPhoto);
            this.Name = "UserBook";
            this.Size = new System.Drawing.Size(256, 370);
            this.Load += new System.EventHandler(this.UserBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPhoto;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnRomove;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDescr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;


        public string Descr
        {
            get => txtDescr.Text;
            set => txtDescr.Text = value;
        }
        public string Price
        {
            get => txtPrice.Text;
            set => txtPrice.Text=value;
        }
        public Image Pic
        {
            get => picPhoto.Image;
            set => picPhoto.Image = value;
        }
    }
}
