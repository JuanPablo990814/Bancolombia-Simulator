using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Controlador;

namespace Vista
{
    public partial class SolicitudCredito : Form
    {
        clsVariables objVar;
        clsControlador objControlador;
        

        public SolicitudCredito()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            objVar = new clsVariables();
            objControlador = new clsControlador(objVar);

            objVar.Cedula = Convert.ToInt64(txtCedula.Text);
            try
            {
                objControlador.mtConsultaClientePrestamo();

                dgvSolicitudCredito.DataSource = objVar.dttProductos;
            }
            catch
            {
                MessageBox.Show("El cliente no existe");
            }

        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void mtTipoPrestamo()
        {
            Bancolombia.referenciaServicioWeb.esteMiWebServicesSoapClient miServicio = new Bancolombia.referenciaServicioWeb.esteMiWebServicesSoapClient();

            if (objVar.TipoPrestamo=="Libre Inversion")
            {
                objVar.ValInteres = miServicio.mtOperaciones(objVar.InteresesLi, objVar.DiaMes);

            }
            else
            {
                if (objVar.TipoPrestamo=="Vehiculos")
                {
                    objVar.ValInteres = miServicio.mtOperaciones(objVar.InteresesVehi, objVar.DiaMes);
                }
                else
                {
                    if (objVar.TipoPrestamo=="Vivienda")
                    {
                        objVar.ValInteres = miServicio.mtOperaciones(objVar.InteresesVivi, objVar.DiaMes);
                    }
                    else
                    {
                        MessageBox.Show("Error en el tipo de prestamo");
                    }
                }
            }
        }

        private void txtCalcular_Click(object sender, EventArgs e)
        {
            objVar = new clsVariables();
            objControlador = new clsControlador(objVar);

            
            try
            {
                objVar.Cedula = Convert.ToInt64(txtCedula.Text);
                objControlador.mtConsultaClientePrestamo();

                objVar.ValPrestamo = Convert.ToDouble(txtPrestamo.Text);
                objVar.NumCuotas = Convert.ToInt16(cmbNumCuotas.Text);
                objVar.TipoPrestamo = cmbTipoPrestamo.Text;
                mtTipoPrestamo();
                MessageBox.Show("Valor Interes " + objVar.ValInteres, "Advertencia", MessageBoxButtons.OK);

                lblCalculado.Text = "Calculado";

                objVar.FlujoCaja = objControlador.mtFlujocaja();
                objControlador.mtEvaluaCredito();

                mtAprobadoNegado();
            }
            catch
            {
                MessageBox.Show("No se salte el primer paso: Ingrese la cedula y confirme la informacion del cliente ", "Error", MessageBoxButtons.OK);
            }
             
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
 

        private void SolicitudCredito_Load(object sender, EventArgs e)
        {

        }

        private void btnCartar_Click(object sender, EventArgs e)
        {
            objControlador = new clsControlador(objVar);

            if (objVar.Estado=="Aprobado")
            {
                
                objControlador.mtPrestamo();
                objControlador.mtDatosCarta();
                objControlador.mtGenerarPDF();
            }
            else
            {
                objControlador.mtDatosCarta();
                objControlador.mtGenerarPDF();
            }
            

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cmbTipoPrestamo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbNumCuotas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void mtAprobadoNegado()
        {
            if (objVar.Estado == "Aprobado")
            {
                MessageBox.Show("Ya puede generar la carta de aprovacion");
            }
            else
            {
                if (objVar.Estado == "Negado")
                {
                    MessageBox.Show("Ya puede generar la carta de rechazo");
                }
                else
                {
                    MessageBox.Show("HOLA", "Error", MessageBoxButtons.OK);
                }
            }
        }
    }
}
