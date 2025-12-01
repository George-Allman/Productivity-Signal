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
    public partial class Session : Control
    {
        public Session()
        {
            InitializeComponent();
            this.BackColor = Theme.Primary;
            this.Width = 1110;
            this.Height = 768;
            this.Left = 264;
            this.Top = 0;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
