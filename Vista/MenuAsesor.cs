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
    public partial class MenuAsesor : Form
    {
        clsVariables objVar;
        clsControlador objControlador= null;

        public MenuAsesor()
        {
            InitializeComponent();
        }

        private void MenuAsesor_Load(object sender, EventArgs e)
        {
            
        }

        private void asesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void tsmAsesor_Click(object sender, EventArgs e)
        {
            
        }

        private void tsmClientes_Click(object sender, EventArgs e)
        {
            ClientesCrud frmClients = new ClientesCrud();
            frmClients.MdiParent = this;
            frmClients.Show();
        }

        private void tsmProductos_Click(object sender, EventArgs e)
        {
            Productos frmProductos = new Productos();
            frmProductos.MdiParent = this;
            frmProductos.Show();
        }

        private void tsmInfoFinanciera_Click(object sender, EventArgs e)
        {
            InfoFinanciera frmInfo = new InfoFinanciera();
            frmInfo.MdiParent = this;
            frmInfo.Show();
        }

        private void tsmSolicitud_Click(object sender, EventArgs e)
        {
            SolicitudCredito frmSolicitud = new SolicitudCredito();
            frmSolicitud.MdiParent = this;
            frmSolicitud.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tsmCerrarSesion_Click(object sender, EventArgs e)
        {
            Form1 frmInicio = new Form1();
            frmInicio.Show();
            this.Visible = false;
        }
    }
}
