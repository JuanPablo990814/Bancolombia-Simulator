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
    public partial class CartaAprobacion : Form
    {
        clsVariables objVar = new clsVariables();
        clsControlador objControl = null;

        public CartaAprobacion()
        {
            InitializeComponent();

            
        }

        private void CartaAprobacion_Load(object sender, EventArgs e)
        {

        }

        private void timFecha_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString();
            lblCreditoAprobado.Text = objVar.ValPrestamo.ToString();
            lblIntereses.Text = objVar.ValorTotalconCadaMes.ToString();
            lblMeses.Text = objVar.NumCuotas.ToString();
            lblValorMes.Text = objVar.ValorTotalconCadaMes.ToString();
            lblInteresMes.Text = objVar.InteresMes.ToString();
            lblTasaMes.Text = objVar.TasaMensual.ToString();
            lblTasaAño.Text = objVar.TasaAnual.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
