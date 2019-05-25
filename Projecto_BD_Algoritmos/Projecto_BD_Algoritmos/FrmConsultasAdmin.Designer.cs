namespace Projecto_BD_Algoritmos
{
    partial class FrmConsultasAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultasAdmin));
            this.dtgConsultasAdmin = new System.Windows.Forms.DataGridView();
            this.cmbConsultasAdmin = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultasAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgConsultasAdmin
            // 
            this.dtgConsultasAdmin.AllowUserToAddRows = false;
            this.dtgConsultasAdmin.AllowUserToDeleteRows = false;
            this.dtgConsultasAdmin.AllowUserToOrderColumns = true;
            this.dtgConsultasAdmin.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgConsultasAdmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgConsultasAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConsultasAdmin.Enabled = false;
            this.dtgConsultasAdmin.Location = new System.Drawing.Point(13, 13);
            this.dtgConsultasAdmin.Name = "dtgConsultasAdmin";
            this.dtgConsultasAdmin.Size = new System.Drawing.Size(458, 425);
            this.dtgConsultasAdmin.TabIndex = 0;
            // 
            // cmbConsultasAdmin
            // 
            this.cmbConsultasAdmin.FormattingEnabled = true;
            this.cmbConsultasAdmin.Items.AddRange(new object[] {
            "Muestra las caracteristicas de la tabla de los proveedores registrados en el sist" +
                "ema",
            "Muestra los datos de los clientes que hicieron su primer factura",
            "Muestra los productos que vendieron mas de 3 articulos",
            "Muestra los productos en el inventario y el proveedor que los administra",
            "Muestra las primeras facturas que se hicieron junto con el nombre del cliente que" +
                " realizo la compra",
            "Muestra los clientes y su direccion y telefono ordenados por abecedario y que hic" +
                "ieron una compra de mas de 5000 pesos",
            "Muestra las categorias que estan disponibles"});
            this.cmbConsultasAdmin.Location = new System.Drawing.Point(512, 13);
            this.cmbConsultasAdmin.Name = "cmbConsultasAdmin";
            this.cmbConsultasAdmin.Size = new System.Drawing.Size(257, 21);
            this.cmbConsultasAdmin.TabIndex = 1;
            this.cmbConsultasAdmin.SelectedIndexChanged += new System.EventHandler(this.cmbConsultasAdmin_SelectedIndexChanged);
            // 
            // FrmConsultasAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbConsultasAdmin);
            this.Controls.Add(this.dtgConsultasAdmin);
            this.Name = "FrmConsultasAdmin";
            this.Text = "FrmConsultasAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultasAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgConsultasAdmin;
        private System.Windows.Forms.ComboBox cmbConsultasAdmin;
    }
}