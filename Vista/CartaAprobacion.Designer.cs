namespace Vista
{
    partial class CartaAprobacion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartaAprobacion));
            this.label1 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.timFecha = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCreditoAprobado = new System.Windows.Forms.Label();
            this.lblIntereses = new System.Windows.Forms.Label();
            this.lblValorMes = new System.Windows.Forms.Label();
            this.lblInteresMes = new System.Windows.Forms.Label();
            this.lblTasaMes = new System.Windows.Forms.Label();
            this.lblTasaAño = new System.Windows.Forms.Label();
            this.lblMeses = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medellin -";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(94, 113);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha";
            // 
            // timFecha
            // 
            this.timFecha.Tick += new System.EventHandler(this.timFecha_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "ATT:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // pictureBox2
            //this.pictureBox2.Image = global::Vista.Properties.Resources.FIRMA;
            this.pictureBox2.Location = new System.Drawing.Point(18, 394);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(139, 72);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            //this.pictureBox1.Image = global::Vista.Properties.Resources.Bancolombia;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(437, 234);
            this.label2.TabIndex = 9;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(15, 167);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 23;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(15, 154);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(40, 13);
            this.lblCedula.TabIndex = 22;
            this.lblCedula.Text = "Cedula";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(51, 141);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 21;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCreditoAprobado
            // 
            this.lblCreditoAprobado.AutoSize = true;
            this.lblCreditoAprobado.Location = new System.Drawing.Point(209, 230);
            this.lblCreditoAprobado.Name = "lblCreditoAprobado";
            this.lblCreditoAprobado.Size = new System.Drawing.Size(37, 13);
            this.lblCreditoAprobado.TabIndex = 24;
            this.lblCreditoAprobado.Text = "00000";
            // 
            // lblIntereses
            // 
            this.lblIntereses.AutoSize = true;
            this.lblIntereses.Location = new System.Drawing.Point(236, 243);
            this.lblIntereses.Name = "lblIntereses";
            this.lblIntereses.Size = new System.Drawing.Size(37, 13);
            this.lblIntereses.TabIndex = 25;
            this.lblIntereses.Text = "00000";
            // 
            // lblValorMes
            // 
            this.lblValorMes.AutoSize = true;
            this.lblValorMes.Location = new System.Drawing.Point(198, 269);
            this.lblValorMes.Name = "lblValorMes";
            this.lblValorMes.Size = new System.Drawing.Size(37, 13);
            this.lblValorMes.TabIndex = 26;
            this.lblValorMes.Text = "00000";
            // 
            // lblInteresMes
            // 
            this.lblInteresMes.AutoSize = true;
            this.lblInteresMes.Location = new System.Drawing.Point(227, 282);
            this.lblInteresMes.Name = "lblInteresMes";
            this.lblInteresMes.Size = new System.Drawing.Size(37, 13);
            this.lblInteresMes.TabIndex = 27;
            this.lblInteresMes.Text = "00000";
            // 
            // lblTasaMes
            // 
            this.lblTasaMes.AutoSize = true;
            this.lblTasaMes.Location = new System.Drawing.Point(236, 295);
            this.lblTasaMes.Name = "lblTasaMes";
            this.lblTasaMes.Size = new System.Drawing.Size(19, 13);
            this.lblTasaMes.TabIndex = 28;
            this.lblTasaMes.Text = "00";
            // 
            // lblTasaAño
            // 
            this.lblTasaAño.AutoSize = true;
            this.lblTasaAño.Location = new System.Drawing.Point(236, 308);
            this.lblTasaAño.Name = "lblTasaAño";
            this.lblTasaAño.Size = new System.Drawing.Size(19, 13);
            this.lblTasaAño.TabIndex = 29;
            this.lblTasaAño.Text = "00";
            // 
            // lblMeses
            // 
            this.lblMeses.AutoSize = true;
            this.lblMeses.Location = new System.Drawing.Point(152, 257);
            this.lblMeses.Name = "lblMeses";
            this.lblMeses.Size = new System.Drawing.Size(19, 13);
            this.lblMeses.TabIndex = 30;
            this.lblMeses.Text = "00";
            // 
            // CartaAprobacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(468, 478);
            this.Controls.Add(this.lblMeses);
            this.Controls.Add(this.lblTasaAño);
            this.Controls.Add(this.lblTasaMes);
            this.Controls.Add(this.lblInteresMes);
            this.Controls.Add(this.lblValorMes);
            this.Controls.Add(this.lblIntereses);
            this.Controls.Add(this.lblCreditoAprobado);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "CartaAprobacion";
            this.Text = "CartaAprobacion";
            this.Load += new System.EventHandler(this.CartaAprobacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Timer timFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCreditoAprobado;
        private System.Windows.Forms.Label lblIntereses;
        private System.Windows.Forms.Label lblValorMes;
        private System.Windows.Forms.Label lblInteresMes;
        private System.Windows.Forms.Label lblTasaMes;
        private System.Windows.Forms.Label lblTasaAño;
        private System.Windows.Forms.Label lblMeses;
    }
}