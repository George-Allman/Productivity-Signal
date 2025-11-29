namespace Productivity_Signal
{
    partial class ProductivitySignal
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
            this.pnlNavigation = new System.Windows.Forms.Panel();
            this.navigationButton1 = new Productivity_Signal.NavigationButton();
            this.pnlNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.pnlNavigation.Controls.Add(this.navigationButton1);
            this.pnlNavigation.Location = new System.Drawing.Point(-6, -4);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(271, 773);
            this.pnlNavigation.TabIndex = 0;
            // 
            // navigationButton1
            // 
            this.navigationButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.navigationButton1.Location = new System.Drawing.Point(18, 196);
            this.navigationButton1.Name = "navigationButton1";
            this.navigationButton1.Size = new System.Drawing.Size(268, 79);
            this.navigationButton1.TabIndex = 0;
            // 
            // ProductivitySignal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1364, 761);
            this.Controls.Add(this.pnlNavigation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ProductivitySignal";
            this.Text = "Productivity Signal";
            this.pnlNavigation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNavigation;
        private NavigationButton navigationButton1;
    }
}

