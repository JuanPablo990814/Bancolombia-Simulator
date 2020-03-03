namespace Vista
{
    partial class Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNumCuenta = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.Acciones = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblValDeuda = new System.Windows.Forms.Label();
            this.cmbTipoCredito = new System.Windows.Forms.ComboBox();
            this.cmbTipoProducto = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCedula
            // 
            this.txtCedula.BackColor = System.Drawing.Color.LightGreen;
            this.txtCedula.Location = new System.Drawing.Point(14, 132);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(100, 20);
            this.txtCedula.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cedula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo de Credito";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(459, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "$ Deuda";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(413, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "#Cuenta";
            // 
            // lblNumCuenta
            // 
            this.lblNumCuenta.AutoSize = true;
            this.lblNumCuenta.Location = new System.Drawing.Point(426, 27);
            this.lblNumCuenta.Name = "lblNumCuenta";
            this.lblNumCuenta.Size = new System.Drawing.Size(19, 13);
            this.lblNumCuenta.TabIndex = 8;
            this.lblNumCuenta.Text = "__";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(146, 64);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 9;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(50, 64);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.txtBuscar_Click);
            // 
            // Acciones
            // 
            this.Acciones.AutoSize = true;
            this.Acciones.Location = new System.Drawing.Point(111, 48);
            this.Acciones.Name = "Acciones";
            this.Acciones.Size = new System.Drawing.Size(51, 13);
            this.Acciones.TabIndex = 11;
            this.Acciones.Text = "Acciones";
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(8, 173);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(499, 180);
            this.dgvProductos.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(264, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "-Para buscar los productos solo es necesaria la cedula";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Tipos de productos:";
            // 
            // lblValDeuda
            // 
            this.lblValDeuda.AutoSize = true;
            this.lblValDeuda.Location = new System.Drawing.Point(478, 135);
            this.lblValDeuda.Name = "lblValDeuda";
            this.lblValDeuda.Size = new System.Drawing.Size(13, 13);
            this.lblValDeuda.TabIndex = 16;
            this.lblValDeuda.Text = "0";
            // 
            // cmbTipoCredito
            // 
            this.cmbTipoCredito.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbTipoCredito.FormattingEnabled = true;
            this.cmbTipoCredito.Items.AddRange(new object[] {
            "MasterCard",
            "MasterCard Gold",
            "Maestro"});
            this.cmbTipoCredito.Location = new System.Drawing.Point(145, 131);
            this.cmbTipoCredito.Name = "cmbTipoCredito";
            this.cmbTipoCredito.Size = new System.Drawing.Size(102, 21);
            this.cmbTipoCredito.TabIndex = 17;
            this.cmbTipoCredito.SelectedIndexChanged += new System.EventHandler(this.cmbTipoCredito_SelectedIndexChanged);
            // 
            // cmbTipoProducto
            // 
            this.cmbTipoProducto.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbTipoProducto.FormattingEnabled = true;
            this.cmbTipoProducto.Items.AddRange(new object[] {
            "Ahorros",
            "Credito"});
            this.cmbTipoProducto.Location = new System.Drawing.Point(290, 132);
            this.cmbTipoProducto.Name = "cmbTipoProducto";
            this.cmbTipoProducto.Size = new System.Drawing.Size(102, 21);
            this.cmbTipoProducto.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bancolombia.Properties.Resources.Bancolombia;
            this.pictureBox1.Location = new System.Drawing.Point(74, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(519, 368);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbTipoProducto);
            this.Controls.Add(this.cmbTipoCredito);
            this.Controls.Add(this.lblValDeuda);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.Acciones);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblNumCuenta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCedula);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNumCuenta;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label Acciones;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblValDeuda;
        private System.Windows.Forms.ComboBox cmbTipoCredito;
        private System.Windows.Forms.ComboBox cmbTipoProducto;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}