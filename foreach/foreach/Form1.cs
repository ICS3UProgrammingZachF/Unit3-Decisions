using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @foreach
{
    public partial class Form1 : Form
    {
        Font Sans = new Font("Racer", 20, FontStyle.Italic);
        Font RD = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl1_Click(object sender, EventArgs e)
        {
            foreach (Control FontControl in this.Controls)
            {
                if (FontControl.GetType() == typeof(Label))
                {
                    FontControl.BackColor = Color.DarkCyan;
                    FontControl.ForeColor = Color.Gainsboro;
                    Font = Sans;
                }
                else if (FontControl.GetType() == typeof(Button))
                {
                    FontControl.BackColor = Color.White;
                    FontControl.ForeColor = Color.Goldenrod;
                    Font = Sans;
                }
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            foreach (Control Control in this.Controls)
            {
                if (Control.GetType() == typeof(Label))
                {
                    Control.BackColor = Color.Red;
                    Control.ForeColor = Color.DarkBlue;
                    Font = RD;                  
                }
                else if (Control.GetType() == typeof(Button))
                {
                    Control.BackColor = Color.LawnGreen;
                    Control.ForeColor = Color.Orchid;
                    Font = RD;

                }
            }            
        }
    }
}
