using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock__Paper__Scissors_zach
{
    public partial class RockPaperScissors : Form
    {
        const int MIN_VALUE = 1, MAX_VALUE = 3;
        int player_pick, cpu_pick;
        Random Rng;
        

        private void RockPaperScissors_Load(object sender, EventArgs e)
        {
            lblscore.Hide();
            radhide.Hide();

            grbcpu.Enabled = false;

            radhide.Checked = true;


        }

        private void btnVs_Click(object sender, EventArgs e)
        {
            lblscore.Show();

            const int ROCK = 1;
            const int PAPAER = 2;
            const int SCISSORS = 3;

            const int Radhides = 0;

          

            if (radrock.Checked == true)
            {
                player_pick = ROCK;
            }

            else if (radpaper.Checked == true)
            {
                player_pick = PAPAER;
            }
            else if (radscissors.Checked == true)
                {
                    player_pick = SCISSORS;
                }
            if (radhide.Checked == true)
            { player_pick = Radhides; }

          
            cpu_pick = Rng.Next(MIN_VALUE, MAX_VALUE + 1);

            if (radcpurock.Checked == true)
            {
                cpu_pick = ROCK;
            }
            else if (radcpupaper.Checked == true)
            {
                cpu_pick = PAPAER;
            }
            else if (radcpuscissors.Checked == true)
            {
                cpu_pick = SCISSORS;
            }

            if (player_pick == ROCK)
            {
                if (cpu_pick == ROCK)
                    lblscore.Text = "draw";
                else if (cpu_pick == PAPAER)
                    lblscore.Text = "copmuter wins";
                else if (cpu_pick == SCISSORS)
                    lblscore.Text = "you win";
            }
            if (player_pick == PAPAER)
            {
                if (cpu_pick == PAPAER)
                    lblscore.Text = "draw";
                else if (cpu_pick == SCISSORS)
                    lblscore.Text = "copmuter wins";
                else if (cpu_pick == ROCK)
                    lblscore.Text = "you win";
            }
            if (player_pick == SCISSORS)
            {
                if (cpu_pick == SCISSORS)
                    lblscore.Text = "draw";
                else if (cpu_pick == ROCK)
                    lblscore.Text = "copmuter wins";
                else if (cpu_pick == PAPAER)
                    lblscore.Text = "you win";
              

                    
            }

            if (player_pick == Radhides)
                lblscore.Text = "pick rock paper scissors";








        }

        public RockPaperScissors()
        {
            InitializeComponent();

            Rng = new Random();
        }

      
    }
}
