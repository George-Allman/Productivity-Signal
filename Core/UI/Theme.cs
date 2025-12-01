using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productivity_Signal
{
    public static class Theme
    {
        public static Color Primary => Color.FromArgb(255, 52, 52, 52);
        public static Color PrimaryClick => Color.FromArgb(255, 90, 90, 90);
        public static Color PrimaryHover => Color.FromArgb(255, 70, 70, 70);
        public static Color Secondary => Color.FromArgb(255, 38, 38, 38);
        public static Color SecondaryClick => Color.FromArgb(255, 70, 70, 70);
        public static Color SecondaryHover => Color.FromArgb(255, 50, 50, 50);
        public static Color Tertiary => Color.FromArgb(255, 255, 221, 0);
    }
}
