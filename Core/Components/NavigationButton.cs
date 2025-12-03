using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Productivity_Signal.Core.Components
{
    public partial class NavigationButton : Control
    {
        public event EventHandler ButtonClicked;


        private bool selected = true;
        private bool clicked = false;
        private bool hover = false;
        private Image icon;
        private UserControl tab;

        public UserControl Tab
        {
            get => tab;
            set
            {
                tab = value;
                Invalidate(); // Force repaint
            }
        }
        public Image Icon
        {
            get => icon;
            set
            {
                icon = value;
                Invalidate(); // Force repaint
            }
        }
        public bool Selected
        {
            get => selected;
            set
            {
                selected = value;
                Invalidate(); // Forces redraw
            }
        }
        public bool Hover
        {
            get => hover;
            set
            {
                hover = value;
                Invalidate(); // Forces redraw
            }
        }
        public bool Clicked
        {
            get => clicked;
            set
            {
                clicked = value;
                Invalidate(); // Forces redraw
            }
        }

        public NavigationButton()
        {
            InitializeComponent();
            this.Width = 271;
            this.Height = 100;
            SetStyle(ControlStyles.AllPaintingInWmPaint |
             ControlStyles.OptimizedDoubleBuffer |
             ControlStyles.UserPaint |
             ControlStyles.ResizeRedraw, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            SolidBrush pen = new SolidBrush(Color.White);
            Font font = new Font("Segoe UI Semibold", 15, FontStyle.Regular);

            var textSize = g.MeasureString(Text, font);
            var point = new Point(30, ((Height - (int)textSize.Height) / 2));
            g.DrawString(this.Text, font, pen, point);
            pen.Dispose();


            if (icon != null)
            {
                g.DrawImage(icon, this.Width-85,25,50,50);
            }
                

        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            SolidBrush primaryBrush;
            SolidBrush secondaryBrush;

            if (selected)
            {
                if (clicked)
                {
                    primaryBrush = new SolidBrush(Theme.PrimaryClick);
                    secondaryBrush = new SolidBrush(Theme.Tertiary);
                    clickAnim();

                }
                else if (hover)
                {
                    primaryBrush = new SolidBrush(Theme.PrimaryHover);
                    secondaryBrush = new SolidBrush(Theme.Tertiary);
                }
                else
                {
                    primaryBrush = new SolidBrush(Theme.Primary);
                    secondaryBrush = new SolidBrush(Theme.Tertiary);
                }

            }
            else
            {

                if (clicked)
                {
                    primaryBrush = new SolidBrush(Theme.SecondaryClick);
                    secondaryBrush = new SolidBrush(Theme.SecondaryClick);
                    clickAnim();

                }
                else if (hover)
                {
                    primaryBrush = new SolidBrush(Theme.SecondaryHover);
                    secondaryBrush = new SolidBrush(Theme.SecondaryHover);
                }
                else
                {
                    primaryBrush = new SolidBrush(Theme.Secondary);
                    secondaryBrush = new SolidBrush(Theme.Secondary);
                }
            }
            g.FillRectangle(primaryBrush, 15, 0, this.Width - 15, this.Height);
            g.FillRectangle(secondaryBrush, 0, 0, 15, this.Height);

            primaryBrush.Dispose();
            secondaryBrush.Dispose();


        }

        private async void clickAnim()
        {
            await Task.Delay(100);
            Clicked = false;
        }

        // In your NavigationButton class
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e); // Important to allow external subscribers
            ButtonClicked?.Invoke(this, e);
            Clicked = true;
            Selected = true;
            Tab.BringToFront();
        }


        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            Hover = true;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            Hover = false;
        }
    }
}
