using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lOGIN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lineShape1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textuser_Enter(object sender, EventArgs e)
        {
            if (textuser.Text == "USUARIO")
            {
                textuser.Text = "";
                textuser.ForeColor = Color.LightGray;
            }
        }

        private void textuser_Leave(object sender, EventArgs e)
        {
            if (textuser.Text == "")
            {
                textuser.Text = "USUARIO";
                textuser.ForeColor = Color.DimGray;
            }
        }

        private void textpass_Enter(object sender, EventArgs e)
        {
            if (textpass.Text == "CONTRASEÑA")
            {
                textpass.Text = "";
                textpass.ForeColor = Color.LightGray;
                textpass.UseSystemPasswordChar = true;
            }
        }

        private void textpass_Leave(object sender, EventArgs e)
        {
            if (textpass.Text == "")
            {
                textpass.Text = "CONTRASEÑA";
                textpass.ForeColor = Color.LightGray;
                textpass.UseSystemPasswordChar = false;
            }
        }
    }
}
