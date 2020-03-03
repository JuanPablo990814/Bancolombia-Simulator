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
    public partial class Productos : Form
    {
        clsVariables objVar;
        clsControlador objControl;

        public Productos()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscar_Click(object sender, EventArgs e)
        {
            objVar = new clsVariables();
            objControl = new clsControlador(objVar);

            objVar.Cedula = Convert.ToInt64(txtCedula.Text);
            objControl.mtConsultarProducto();

            cmbTipoCredito.Text = objVar.TipoProducto;
            lblValDeuda.Text = objVar.Deuda.ToString();
            lblNumCuenta.Text = objVar.NumeroCuenta.ToString();

            
            dgvProductos.DataSource = objVar.dttProductos;
        
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            objVar = new clsVariables();
            objControl = new clsControlador(objVar);

            try
            {
                objVar.Cedula = Convert.ToInt64(txtCedula.Text);
                objVar.TipoCredito = cmbTipoCredito.Text;
                objVar.TipoProducto = cmbTipoProducto.Text;
                objVar.Deuda = Convert.ToDouble(lblValDeuda.Text);

                objControl.mtIngresarProductos();

                MessageBox.Show("Producto Ingresado", "Advertencia", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("La cedula ingresada no coincide con ningun cliente o ya tiene un producto activo", "Error", MessageBoxButtons.OK);

            }
            
        }

        private void cmbTipoCredito_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
