using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chocolateBoxs
{
    public partial class chocolatebox : Form
    {

        
        public chocolatebox()
        {
            InitializeComponent();

            lblchocolate.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const int MAX_VALUE = 20, MIN_VALUE = 0, MED_VALUE = 10;
            int chocolatebox;

            chocolatebox = int.Parse(txt.Text);

            if (MAX_VALUE < chocolatebox)
                lblchocolate.Text = "you get a prize";
            else if (MED_VALUE < chocolatebox)
                lblchocolate.Text = "you get a small prize";
            else if (MIN_VALUE < chocolatebox)
                lblchocolate.Text = "Good try";
            else if (MIN_VALUE == chocolatebox)
                lblchocolate.Text = "sell a chocolate box next time";

            lblchocolate.Show();


        }
    }
}
