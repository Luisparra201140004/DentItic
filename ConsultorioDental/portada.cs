﻿using System;
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
    public partial class portada : Form
    {
        public portada()
        {
            InitializeComponent();
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void pcteBoxcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void portada_Load(object sender, EventArgs e)
        {

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void portada_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void panelarrastrarport_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            pacienteadministrador objp1 = new pacienteadministrador();
            objp1.Show();
        }
    }
}
