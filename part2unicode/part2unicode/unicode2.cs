using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace part2unicode
{
    public partial class unicode2 : Form
    {
        public unicode2()
        {
            InitializeComponent();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //local continats and vaiubles
            const int UNICODE_CAPTIALS = 90, UNICODE_LOWERCASE = 122;
            int unicode_conter_caps , unicode_conter_low ;
            string characterBig, charactersmall;

            //clear the list box
            lstUnicode.Items.Clear();

            for (unicode_conter_caps = 65; unicode_conter_caps <= UNICODE_CAPTIALS; unicode_conter_caps++)
            {
              
               
                for (unicode_conter_low = 97; unicode_conter_low <= UNICODE_LOWERCASE; unicode_conter_low++)
                {
                   
                    characterBig = char.ConvertFromUtf32(unicode_conter_caps);
                    
                    charactersmall = char.ConvertFromUtf32(unicode_conter_low);
                    
                    lstUnicode.Items.Add(characterBig + " -> " + charactersmall);
                }
            }

        }
       
    }
}
