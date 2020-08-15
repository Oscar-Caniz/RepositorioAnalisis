using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnslide_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 83;
            }
            else
                MenuVertical.Width = 250;
        }
        private void AbrirFormInPanel(object Formhijo)
        {
          
        }
        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void btnProye_Click(object sender, EventArgs e)
        {

        }
    }
}
