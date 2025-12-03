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
        private int numButtons = 3;
        private NavigationButton[] buttons; 

        public ProductivitySignal()
        {
            InitializeComponent();

            buttons = new NavigationButton[numButtons];
            int i = 0;

            foreach(Control ctrl in pnlNavigation.Controls)
            {
                if (ctrl is NavigationButton btn && i < numButtons)
                {
                    buttons[i] = btn;
                    btn.ButtonClicked += navigate;
                    i++;
                }
            }
            Console.WriteLine(buttons[0]);
        }

        private void navigate(Object sender, EventArgs e)
        {
            foreach (NavigationButton btn in buttons)
            {
                btn.Selected = false;
                Console.WriteLine("Hello");
            }
        }
    }
}
