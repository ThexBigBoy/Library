
namespace Midterm
{
    partial class Switch
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buy = new System.Windows.Forms.Label();
            this.borrow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buy
            // 
            this.buy.AutoSize = true;
            this.buy.Font = new System.Drawing.Font("Romnea", 11.25F, System.Drawing.FontStyle.Bold);
            this.buy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buy.Location = new System.Drawing.Point(87, 217);
            this.buy.Name = "buy";
            this.buy.Size = new System.Drawing.Size(42, 27);
            this.buy.TabIndex = 0;
            this.buy.Text = "Buy";
            this.buy.Click += new System.EventHandler(this.buy_Click);
            // 
            // borrow
            // 
            this.borrow.AutoSize = true;
            this.borrow.Font = new System.Drawing.Font("Romnea", 11.25F, System.Drawing.FontStyle.Bold);
            this.borrow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.borrow.Location = new System.Drawing.Point(384, 217);
            this.borrow.Name = "borrow";
            this.borrow.Size = new System.Drawing.Size(68, 27);
            this.borrow.TabIndex = 1;
            this.borrow.Text = "Borrow";
            this.borrow.Click += new System.EventHandler(this.borrow_Click);
            // 
            // Switch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(578, 360);
            this.Controls.Add(this.borrow);
            this.Controls.Add(this.buy);
            this.Name = "Switch";
            this.Text = "Switch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label buy;
        private System.Windows.Forms.Label borrow;
    }
}