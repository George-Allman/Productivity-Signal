using Productivity_Signal.Core.Components;
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
    public partial class ProductivitySignal : Form
    {
        private NavigationButton[] buttons;

        public ProductivitySignal()
        {
            InitializeComponent();

            foreach(Control ctrl in Controls)
            {
                if(ctrl is NavigationButton btn)
                {
                    buttons.Append(btn);
                    btn.ButtonClicked += navigate;
                }
            }
        }

        private void navigate(Object sender, EventArgs e)
        {
            foreach (NavigationButton btn in buttons)
            {
                if (btn == (NavigationButton)sender)
                {
                    btn.Selected = true;
                }
                else
                {
                    btn.Selected = false;
                }
            }
        }
    }
}
