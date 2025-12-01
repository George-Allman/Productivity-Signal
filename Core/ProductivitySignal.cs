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
        public ProductivitySignal()
        {
            InitializeComponent();
            Session session = new Session();
            this.Controls.Add(session);
            session.BringToFront();
        }
    }
}
