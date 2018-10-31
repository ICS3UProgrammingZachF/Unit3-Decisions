using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoWhileLoop
{
    public partial class DoWhileLoop : Form
    {
        public DoWhileLoop()
        {
            InitializeComponent();

            lblanwser.Hide();
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            double factorialanwser, factorialnumber;
            int factorial_counter;


            lstDo.Items.Clear();

            factorialanwser = 1;

            factorialnumber = Convert.ToDouble(txtdowhile.Text);

            factorial_counter = 0;

            do
            {
                factorial_counter++;

                lstDo.Items.Add(factorial_counter);

                factorialanwser = factorialanwser * factorial_counter;

            } while (factorial_counter < factorialnumber);
            lblanwser.Text = txtdowhile.Text + "! =" + Convert.ToString(factorialanwser);

            lblanwser.Show();



        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
