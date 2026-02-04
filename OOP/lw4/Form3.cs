using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lw4
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void darkTheme_CheckedChanged(object sender, EventArgs e)
        {
            if (darkTheme.Checked)
            {
                foreach (Control c in this.Controls)
                {
                    if (c == darkTheme) continue;
                    c.BackColor = Color.DarkGray;
                    c.ForeColor = Color.White;
                }
            }
            else
            {
                foreach (Control c in this.Controls)
                {
                    if (c == darkTheme) continue;
                    c.BackColor = SystemColors.Control;
                    c.ForeColor = SystemColors.ControlText;
                }
            }
        }
    }
}
