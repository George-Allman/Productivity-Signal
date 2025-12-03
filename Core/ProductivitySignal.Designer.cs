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
            this.Tab_Settings = new Productivity_Signal.Core.Components.Settings();
            this.Tab_Analytics = new Productivity_Signal.Core.Components.Analytics();
            this.Tab_Session = new Productivity_Signal.Core.Components.Session();
            this.btnSettings = new Productivity_Signal.Core.Components.NavigationButton();
            this.btnAnalytics = new Productivity_Signal.Core.Components.NavigationButton();
            this.btnSession = new Productivity_Signal.Core.Components.NavigationButton();
            this.pnlNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.pnlNavigation.Controls.Add(this.btnSettings);
            this.pnlNavigation.Controls.Add(this.btnAnalytics);
            this.pnlNavigation.Controls.Add(this.btnSession);
            this.pnlNavigation.Location = new System.Drawing.Point(0, 0);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(272, 762);
            this.pnlNavigation.TabIndex = 0;
            // 
            // Tab_Settings
            // 
            this.Tab_Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.Tab_Settings.Location = new System.Drawing.Point(272, 0);
            this.Tab_Settings.Name = "Tab_Settings";
            this.Tab_Settings.Size = new System.Drawing.Size(1097, 769);
            this.Tab_Settings.TabIndex = 3;
            // 
            // Tab_Analytics
            // 
            this.Tab_Analytics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.Tab_Analytics.Location = new System.Drawing.Point(272, 0);
            this.Tab_Analytics.Name = "Tab_Analytics";
            this.Tab_Analytics.Size = new System.Drawing.Size(1097, 769);
            this.Tab_Analytics.TabIndex = 2;
            // 
            // Tab_Session
            // 
            this.Tab_Session.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.Tab_Session.Location = new System.Drawing.Point(272, 0);
            this.Tab_Session.Name = "Tab_Session";
            this.Tab_Session.Size = new System.Drawing.Size(1097, 769);
            this.Tab_Session.TabIndex = 1;
            // 
            // btnSettings
            // 
            this.btnSettings.Clicked = false;
            this.btnSettings.Hover = false;
            this.btnSettings.Icon = global::Productivity_Signal.Properties.Resources.settingsIcon;
            this.btnSettings.Location = new System.Drawing.Point(6, 422);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Selected = false;
            this.btnSettings.Size = new System.Drawing.Size(265, 100);
            this.btnSettings.Tab = this.Tab_Settings;
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "Settings";
            // 
            // btnAnalytics
            // 
            this.btnAnalytics.Clicked = false;
            this.btnAnalytics.Hover = false;
            this.btnAnalytics.Icon = global::Productivity_Signal.Properties.Resources.graphIcon;
            this.btnAnalytics.Location = new System.Drawing.Point(6, 322);
            this.btnAnalytics.Name = "btnAnalytics";
            this.btnAnalytics.Selected = false;
            this.btnAnalytics.Size = new System.Drawing.Size(265, 100);
            this.btnAnalytics.Tab = this.Tab_Analytics;
            this.btnAnalytics.TabIndex = 1;
            this.btnAnalytics.Text = "Analytics";
            // 
            // btnSession
            // 
            this.btnSession.Clicked = false;
            this.btnSession.Hover = false;
            this.btnSession.Icon = global::Productivity_Signal.Properties.Resources.cameraIcon;
            this.btnSession.Location = new System.Drawing.Point(6, 222);
            this.btnSession.Name = "btnSession";
            this.btnSession.Selected = true;
            this.btnSession.Size = new System.Drawing.Size(265, 100);
            this.btnSession.Tab = this.Tab_Session;
            this.btnSession.TabIndex = 0;
            this.btnSession.Text = "Start Session";
            // 
            // ProductivitySignal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1364, 761);
            this.Controls.Add(this.Tab_Session);
            this.Controls.Add(this.pnlNavigation);
            this.Controls.Add(this.Tab_Settings);
            this.Controls.Add(this.Tab_Analytics);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ProductivitySignal";
            this.Text = "Productivity Signal";
            this.pnlNavigation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNavigation;
        private Core.Components.NavigationButton btnSession;
        private Core.Components.NavigationButton btnAnalytics;
        private Core.Components.NavigationButton btnSettings;
        private Core.Components.Session Tab_Session;
        private Core.Components.Analytics Tab_Analytics;
        private Core.Components.Settings Tab_Settings;
    }
}

