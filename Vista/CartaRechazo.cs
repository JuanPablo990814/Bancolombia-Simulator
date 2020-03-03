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
    public partial class CartaRechazo : Form
    {
        clsVariables objVar = new clsVariables();
        clsControlador objControl = null;

        public CartaRechazo()
        {
            InitializeComponent();


            lblNombre.Text = objVar.Nombre;
            lblCedula.Text = objVar.Cedula.ToString();
            lblDireccion.Text = objVar.Direccion;
            lblMensaje1.Text = objVar.Mensaje1;
            lblMensaje2.Text = objVar.Mensaje2;
            lblMensaje3.Text = objVar.Mensaje3;
            lblMensaje4.Text = objVar.Mensaje4;

        }
        

        private void lblFecha_Click(object sender, EventArgs e)
        {
            
        }

        private void timFecha_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString();
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {
            
        }

        private void CartaRechazo_Load(object sender, EventArgs e)
        {

        }
    }
}
