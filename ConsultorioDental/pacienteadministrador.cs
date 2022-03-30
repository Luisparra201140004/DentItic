using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ConsultorioDental
{
    public partial class pacienteadministrador : Form
    {
        public pacienteadministrador()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pacienteadministrador_Load(object sender, EventArgs e)
        {

        }
        [DllImport("user32.DLL",EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            paneldesplegable.Visible = false;
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void paneldesplegable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn3Admi_Click(object sender, EventArgs e)
        {
            paneldesplegable.Visible = true;
        }

        private void btn1Actualizar_Click(object sender, EventArgs e)
        {
            paneldesplegable.Visible = false;
        }

        private void btn1Paciente_Click(object sender, EventArgs e)
        {

        }
    }
}
