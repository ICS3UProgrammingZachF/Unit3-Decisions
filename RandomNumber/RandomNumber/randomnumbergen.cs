using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumber
{
    public partial class randomnumbergen : Form
    {
        

        public randomnumbergen()
        {
            InitializeComponent();

            lblanwser.Hide();
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            const int MIN_VALUE = 1 , MAX_VALUE = 20 , THE_NUMBER = 17;
            int randomvalue;
            Random Rng = new Random();

            randomvalue = Rng.Next(MIN_VALUE, MAX_VALUE + 1);

            lblanwser.Text = Convert.ToString(randomvalue);

            lblanwser.Show();

            if (randomvalue == THE_NUMBER)
                lblanwser.Text = Convert.ToString (randomvalue) + " you win";
                
        }
    }
}
