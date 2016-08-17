using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SHI_ARCONTEXTCONSIDERED
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        
        int Click = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            Click++;
            switch (Click)
            {
                case 1:
                    pictureBox1.Image = SHI_ARCONTEXTCONSIDERED.Properties.Resources.LILANDRA;
                    break;
                case 2:
                    pictureBox1.Image = SHI_ARCONTEXTCONSIDERED.Properties.Resources.GALACTUS;
                    break;
                case 3:
                    pictureBox1.Image = SHI_ARCONTEXTCONSIDERED.Properties.Resources.ETERNITY;
                    break;
                case 4:
                    pictureBox1.Image = SHI_ARCONTEXTCONSIDERED.Properties.Resources.Nolgor_Subsector;
                    break;
                case 5:
                    pictureBox1.Image = SHI_ARCONTEXTCONSIDERED.Properties.Resources.DRDOOM;
                    break;
                case 6:
                    pictureBox1.Image = SHI_ARCONTEXTCONSIDERED.Properties.Resources.CAPITALONE;
                    break;
                case 7:
                    pictureBox1.Image = SHI_ARCONTEXTCONSIDERED.Properties.Resources.VPROGRAM1;
                    break;
                case 8:
                    pictureBox1.Image = SHI_ARCONTEXTCONSIDERED.Properties.Resources.VPROGRAM2;
                    Click = 0;
                    break;
                default:
                    break;
            }
        }
    }
}
