using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace squarsZach
{
    public partial class squareroot : Form
    {
        public squareroot()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //local varibles
            int endingVlaue, value = 1, squareRootAsInt;
            Double squarerootAsDouble;

            //clear all items form list box
            lstroot.Items.Clear();

            // get the vlaue the user enterd in the list box
            endingVlaue = Convert.ToInt32(this.nudvlaue.Value);

            //contine stating any perfect squares between themin vlaue and the vlaue the user picked
            while (value <= endingVlaue)
            {
                //takes the square root of vlaue
                squarerootAsDouble = Math.Sqrt(value);

                //convert double to an int form a double
                squareRootAsInt = Convert.ToInt32(squarerootAsDouble);

                //the only way for both he decimals to be equal if the value was a perfect square
                if (squareRootAsInt == squarerootAsDouble)
                {
                    lstroot.Items.Add(value + " this is a perfect square");
                    //refresh the program
                    Refresh();
                }
                // increment
                value++;
            }
        }
    }
}
