using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegrador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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
    }
}
