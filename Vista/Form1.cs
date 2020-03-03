using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;

namespace Vista
{
    public partial class Form1 : Form
    {

        clsVariables objVar;
        clsControlador objControlador;
        
        public Form1()
        {
        
            InitializeComponent();

        }

        private void tsmClientes_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            objVar = new clsVariables();
            objControlador = new clsControlador(objVar);

            try
            {
                objVar.Usuario = txtUsuario.Text;
                objVar.Contraseña = txtContraseña.Text;
                objControlador.mtVerificarUsuario();
                MessageBox.Show("Bienvenido Ascesor " + objVar.Usuario, "Notificacion", MessageBoxButtons.OK);
                this.Visible = false;
                MenuAsesor frmMenu = new MenuAsesor();
                frmMenu.Show();

            }
            catch
            {
                MessageBox.Show("Usuario o contraseña invalido", "Error", MessageBoxButtons.OK);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
