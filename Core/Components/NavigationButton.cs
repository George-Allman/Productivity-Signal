using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Productivity_Signal
{
    public partial class NavigationButton : UserControl
    {
        private Boolean active = true;
        public String title;
        private Font font;

        public NavigationButton()
        {
            InitializeComponent();
            this.Height = 79;
            this.Width = 268;
            this.BackColor = Theme.Primary;
            this.title = "Hello";
            font = new Font("Segoe UI", 12, FontStyle.Bold);
        }

        private void NavigationButton_Load(object sender, EventArgs e)
        {

        }


        public void deActivate()
        {
            this.active = false;
            Invalidate();
        }

        public void activate()
        {
            this.active = true;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graphics = e.Graphics;
            SolidBrush brush = new SolidBrush(Theme.Tertiary) ;
            if (active)
            {
                this.BackColor = Theme.Primary;
                brush = new SolidBrush(Theme.Tertiary);
            }
            else
            {
                this.BackColor = Theme.Secondary;
                brush = new SolidBrush(Theme.Secondary);
            }
            graphics.FillRectangle(brush, 0,0, 20, this.Height);
            SolidBrush pen = new SolidBrush(Color.White);
            Font font = this.Font;
            graphics.DrawString(this.title, font, pen, 40, 10);

            
            

        }
    }
}
