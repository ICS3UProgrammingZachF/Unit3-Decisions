using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unicode
{
    public partial class Unicode : Form
    {
        public Unicode()
        {
            InitializeComponent();
        }

        private void btnsart_Click(object sender, EventArgs e)
        {
            const int UNICODE_NUMBER = 90;
            int unicode_counter;
            string character;


            lstunicode.Items.Clear();

            for (unicode_counter = 65; unicode_counter <= UNICODE_NUMBER ;unicode_counter++ )
            {

                character = char.ConvertFromUtf32(unicode_counter);

                lstunicode.Items.Add(character + " -> " + unicode_counter );
            }
        }
    }
}
