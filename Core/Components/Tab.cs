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
    public partial class Tab : UserControl
    {
        public Tab()
        {
            InitializeComponent();
            this.Width = 1097;
            this.Height = 769;
            this.Left = 272;
            this.Top = 0;
            this.BringToFront();
        }
    }
}
