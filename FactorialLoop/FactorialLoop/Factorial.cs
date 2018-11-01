using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorialLoop
{
    public partial class Factorial : Form
    {
        public Factorial()
        {
            InitializeComponent();
            lblanwser.Hide();
        }

        private void btncount_Click(object sender, EventArgs e)
        {
            double factorialnumber, factorialanwser;
            int factorialcounter;

            lstFactorial.Items.Clear();

            factorialanwser = 1;

            

            factorialnumber = Convert.ToDouble(txtFactorial.Text);

            

            for (factorialcounter = 1; factorialcounter <= factorialnumber; factorialcounter++ )
            {
                lstFactorial.Items.Add(factorialcounter);

                factorialanwser = factorialanwser * factorialcounter;
            }
            lblanwser.Text = txtFactorial.Text + "! =" + Convert.ToString(factorialanwser);

            lblanwser.Show();

        }
    }
}
