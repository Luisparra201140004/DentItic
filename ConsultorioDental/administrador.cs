using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultorioDental
{
    public partial class administrador : Form
    {
        public administrador()
        {
            InitializeComponent();
        }

        private void txtBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBox1_Enter(object sender, EventArgs e)
        {
            if (txtBox1.Text == "") {
                txtBox1.Text = "";
                txtBox1.ForeColor = Color.LightGray;
                txtBox1.UseSystemPasswordChar = true;
            }
        }

        private void txtBox1_Leave(object sender, EventArgs e)
        {
            if (txtBox1.Text == "") {
                txtBox1.Text = "";
                txtBox1.ForeColor = Color.DimGray;
                txtBox1.UseSystemPasswordChar = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
