namespace Vista
{
    partial class MenuAsesor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAsesor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmAsesor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmInfoFinanciera = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSolicitud = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAsesor,
            this.tsmClientes,
            this.tsmProductos,
            this.tsmInfoFinanciera,
            this.tsmSolicitud});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(918, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmAsesor
            // 
            this.tsmAsesor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCerrarSesion});
            this.tsmAsesor.Name = "tsmAsesor";
            this.tsmAsesor.Size = new System.Drawing.Size(54, 20);
            this.tsmAsesor.Text = "Asesor";
            this.tsmAsesor.Click += new System.EventHandler(this.tsmAsesor_Click);
            // 
            // tsmCerrarSesion
            // 
            this.tsmCerrarSesion.Name = "tsmCerrarSesion";
            this.tsmCerrarSesion.Size = new System.Drawing.Size(143, 22);
            this.tsmCerrarSesion.Text = "Cerrar Sesion";
            this.tsmCerrarSesion.Click += new System.EventHandler(this.tsmCerrarSesion_Click);
            // 
            // tsmClientes
            // 
            this.tsmClientes.Name = "tsmClientes";
            this.tsmClientes.Size = new System.Drawing.Size(61, 20);
            this.tsmClientes.Text = "Clientes";
            this.tsmClientes.Click += new System.EventHandler(this.tsmClientes_Click);
            // 
            // tsmProductos
            // 
            this.tsmProductos.Name = "tsmProductos";
            this.tsmProductos.Size = new System.Drawing.Size(73, 20);
            this.tsmProductos.Text = "Productos";
            this.tsmProductos.Click += new System.EventHandler(this.tsmProductos_Click);
            // 
            // tsmInfoFinanciera
            // 
            this.tsmInfoFinanciera.Name = "tsmInfoFinanciera";
            this.tsmInfoFinanciera.Size = new System.Drawing.Size(141, 20);
            this.tsmInfoFinanciera.Text = "Informacion Financiera";
            this.tsmInfoFinanciera.Click += new System.EventHandler(this.tsmInfoFinanciera_Click);
            // 
            // tsmSolicitud
            // 
            this.tsmSolicitud.Name = "tsmSolicitud";
            this.tsmSolicitud.Size = new System.Drawing.Size(123, 20);
            this.tsmSolicitud.Text = "Solicitud de Credito";
            this.tsmSolicitud.Click += new System.EventHandler(this.tsmSolicitud_Click);
            // 
            // MenuAsesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 421);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MenuAsesor";
            this.Text = "Menu Asesor";
            this.Load += new System.EventHandler(this.MenuAsesor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmAsesor;
        private System.Windows.Forms.ToolStripMenuItem tsmClientes;
        private System.Windows.Forms.ToolStripMenuItem tsmProductos;
        private System.Windows.Forms.ToolStripMenuItem tsmInfoFinanciera;
        private System.Windows.Forms.ToolStripMenuItem tsmSolicitud;
        private System.Windows.Forms.ToolStripMenuItem tsmCerrarSesion;
    }
}