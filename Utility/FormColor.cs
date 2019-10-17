using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomPicker.Utility
{
    class FormColor
    {
        public Color BackColor { get; set; }
        public Color ForeColor { get; set; }
        public FlatStyle FlatStyle { get; set; }
        public string ToolTipText { get; set; }

        public FormColor(bool isDark)
        {
            if (isDark)
            {
                BackColor = Color.White;
                ForeColor = Color.Black;
                FlatStyle = FlatStyle.Standard;
                ToolTipText = "Turn ON Dark Mode";
            } else
            {
                BackColor = Color.Black;
                ForeColor = Color.White;
                FlatStyle = FlatStyle.Flat;
                ToolTipText = "Turn OFF Dark Mode";
            }
        }
    }
}
