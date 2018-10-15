using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guessGameZach
{
    public partial class guessGame : Form
    {
    
       
        
         

            public guessGame()
        {
            InitializeComponent();

            pic.Hide();
        }

        private void guessGame_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btncal_Click(object sender, EventArgs e)
        {
            int guessnumber;
            const int THENUMBER = 7;



            guessnumber = (int)(nudan.Value);
            pic.Show();
            if (guessnumber == THENUMBER)
                pic.Image = Properties.Resources.checkmark;

            if (guessnumber > THENUMBER)
                pic.Image = Properties.Resources.red_x;
            if (guessnumber < THENUMBER)
                pic.Image = Properties.Resources.red_x;

           
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
