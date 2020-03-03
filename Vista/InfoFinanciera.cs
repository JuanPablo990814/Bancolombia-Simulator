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
    public partial class InfoFinanciera : Form
    {
        clsVariables objVar;
        clsControlador objControl;

        public InfoFinanciera()
        {
            InitializeComponent();
        }

        private void InfoFinancieracs_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            objVar = new clsVariables();
            objControl = new clsControlador(objVar);

            
            try
            {
                objVar.Cedula = Convert.ToInt64(txtCedula.Text);
                objControl.mtInfoFinanciera();

                txtIngresos.Text = objVar.Ingresos.ToString();
                txtEgresos.Text = objVar.Egresos.ToString();
                txtDeudas.Text = objVar.Deudas.ToString();
                txtScore.Text = objVar.Score.ToString();
                txtNombre.Text = objVar.Nombre;
            }
            catch
            {
                MessageBox.Show("Cedula no encontrada", "Advertencia", MessageBoxButtons.OK);
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        { 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            objVar = new clsVariables();
            objControl = new clsControlador(objVar);
            try
            {
                objVar.Cedula = Convert.ToInt64(txtCedula.Text);
                objVar.Nombre = txtNombre.Text;
                objVar.Ingresos = Convert.ToDouble(txtIngresos.Text);
                objVar.Egresos = Convert.ToDouble(txtEgresos.Text);
                objVar.Deudas = Convert.ToInt16(txtDeudas.Text);
                objVar.Score = Convert.ToInt16(txtScore.Text);

                objControl.mtIngresarInfo();
                MessageBox.Show("Ingresado con exito", "Advertencia", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("El Usuario Ingresado no es cliente", "Advertencia", MessageBoxButtons.OK);
            }
            
        }
    }
}
