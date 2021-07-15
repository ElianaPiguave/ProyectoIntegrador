using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//libreria para mover el formulario
using System.Runtime.InteropServices;

namespace ProyectoIntegrador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "sendMessage")]
        private extern static void sendMessage(System.IntPtr hand, int wmsg, int wparam, int lparam);

        private void txt_usu_Enter(object sender, EventArgs e)
        {
            if (txt_usu.Text == "USUARIO")
            {
                txt_usu.Text = "";
                txt_usu.ForeColor = Color.AntiqueWhite;

            }
        }

        private void txt_usu_Leave(object sender, EventArgs e)
        {

            if (txt_usu.Text =="")
            {
                txt_usu.Text = "USUARIO";
                txt_usu.ForeColor = Color.White;

            }

        }

        private void txt_contra_Enter(object sender, EventArgs e)
        {
            if (txt_contra.Text == "CONTRASENA")
            {
                txt_contra.Text = "";
                txt_contra.ForeColor = Color.White;
                txt_contra.UseSystemPasswordChar = true;
            }
        }

        private void txt_contra_Leave(object sender, EventArgs e)
        {
            if (txt_contra.Text =="")
            {
                txt_contra.Text = "CONTRASENA";
                txt_contra.ForeColor = Color.White;
                txt_contra.UseSystemPasswordChar = false;    

            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            sendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            sendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
