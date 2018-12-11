using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RuningAV
{
    public partial class form2 : Form
    {

        double mark = 0, total = 0, nextNum = 0,average = 0,nummarks;

        public form2()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {

            //local verubles
            

            //convetrs the a sting form textbox to a int
            mark = double.Parse(txt.Text);

            //this makes you only enter a value between 1 - 100
            if (mark > 0 && mark < 100)
            {
                total += mark;
                nummarks++;
                average = total / nummarks;
            }

            else if (mark == -1)
            {             
                btn.Enabled = false;
                txt.Visible = false;
                MessageBox.Show("running average.", "Running Average");
            }

            lbltotal.Text = Convert.ToString(mark);
            lblaverage.Text = Convert.ToString(average);
        }
    }
           
}
