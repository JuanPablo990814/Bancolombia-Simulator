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
    public partial class ClientesCrud : Form
    {
        clsVariables objVar;
        clsControlador objControl;

        public ClientesCrud()
        {
            
            InitializeComponent();
        }

        private void ClientesCrud_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            objVar = new clsVariables();
            objControl = new clsControlador(objVar);
            
            try
            {
                objVar.Cedula = Convert.ToInt64(txtCedula.Text);
                objControl.mtBuscarCliente();
                txtNombre.Text = objVar.Nombre;
                txtDireccion.Text = objVar.Direccion;
                txtTelefono.Text = objVar.Telefono;
            }
            catch
            {
                MessageBox.Show("Cliente no encontrado", "Error", MessageBoxButtons.OK);
            }
            
 
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            objVar = new clsVariables();
            objControl = new clsControlador(objVar);
            objVar.Cedula = Convert.ToInt64(txtCedula.Text);
            try
            {
                objControl.mtBorrarCliente();
                MessageBox.Show("Cliente Borrado","Advertencia",MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Error al borrar cliente o ya a sido borrado","Advertencia",MessageBoxButtons.OK);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            objVar = new clsVariables();
            objControl = new clsControlador(objVar);

            objVar.Cedula = Convert.ToInt64(txtCedula.Text);
            objVar.Nombre = txtNombre.Text;
            objVar.Telefono = txtTelefono.Text;
            objVar.Direccion = txtDireccion.Text;
            try
            {
                objControl.mtInsertarCliente();
                MessageBox.Show("Cliente almacenado con exito", "Advertencia", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Error al ingresar cliente","Advertencia",MessageBoxButtons.OK);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            objVar = new clsVariables();
            objControl = new clsControlador(objVar);

            objVar.Cedula = Convert.ToInt64(txtCedula.Text);
            objVar.Nombre = txtNombre.Text;
            objVar.Telefono = txtTelefono.Text;
            objVar.Direccion = txtDireccion.Text;
            try
            {
                objControl.mtModificarCliente();
                MessageBox.Show("Cliente Modificado con exito", "Advertencia", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Error al Modificar cliente", "Advertencia", MessageBoxButtons.OK);
            }
        }
    }
}
