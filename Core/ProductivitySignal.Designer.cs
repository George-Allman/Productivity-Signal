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
            this.navigationButton2 = new Productivity_Signal.Core.Components.NavigationButton();
            this.navigationButton1 = new Productivity_Signal.Core.Components.NavigationButton();
            this.navigationButton3 = new Productivity_Signal.Core.Components.NavigationButton();
            this.pnlNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.pnlNavigation.Controls.Add(this.navigationButton3);
            this.pnlNavigation.Controls.Add(this.navigationButton2);
            this.pnlNavigation.Controls.Add(this.navigationButton1);
            this.pnlNavigation.Location = new System.Drawing.Point(-6, -4);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(270, 768);
            this.pnlNavigation.TabIndex = 0;
            // 
            // navigationButton2
            // 
            this.navigationButton2.Click = false;
            this.navigationButton2.Hover = false;
            this.navigationButton2.Icon = global::Productivity_Signal.Properties.Resources.graphIcon;
            this.navigationButton2.Location = new System.Drawing.Point(6, 322);
            this.navigationButton2.Name = "navigationButton2";
            this.navigationButton2.Selected = false;
            this.navigationButton2.Size = new System.Drawing.Size(265, 100);
            this.navigationButton2.TabIndex = 1;
            this.navigationButton2.Text = "Analytics";
            // 
            // navigationButton1
            // 
            this.navigationButton1.Click = false;
            this.navigationButton1.Hover = false;
            this.navigationButton1.Icon = global::Productivity_Signal.Properties.Resources.cameraIcon;
            this.navigationButton1.Location = new System.Drawing.Point(6, 222);
            this.navigationButton1.Name = "navigationButton1";
            this.navigationButton1.Selected = true;
            this.navigationButton1.Size = new System.Drawing.Size(265, 100);
            this.navigationButton1.TabIndex = 0;
            this.navigationButton1.Text = "Start Session";
            // 
            // navigationButton3
            // 
            this.navigationButton3.Click = false;
            this.navigationButton3.Hover = false;
            this.navigationButton3.Icon = global::Productivity_Signal.Properties.Resources.settingsIcon;
            this.navigationButton3.Location = new System.Drawing.Point(6, 422);
            this.navigationButton3.Name = "navigationButton3";
            this.navigationButton3.Selected = false;
            this.navigationButton3.Size = new System.Drawing.Size(265, 100);
            this.navigationButton3.TabIndex = 2;
            this.navigationButton3.Text = "Settings";
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
        private Core.Components.NavigationButton navigationButton1;
        private Core.Components.NavigationButton navigationButton2;
        private Core.Components.NavigationButton navigationButton3;
    }
}

