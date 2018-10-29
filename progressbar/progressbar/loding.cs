using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progressbar
{
    public partial class loding : Form
    {
        public loding()
        {
            InitializeComponent();
        }

        private void btnstrat_Click(object sender, EventArgs e)
        {
            const int LODING = 100;
            int valueload = 0;


            do
            {

                prgloding.Value = valueload;
                valueload = valueload + 5;
                Refresh();
            } while (valueload <= LODING);

            
               
            


            

        }
    }
}
