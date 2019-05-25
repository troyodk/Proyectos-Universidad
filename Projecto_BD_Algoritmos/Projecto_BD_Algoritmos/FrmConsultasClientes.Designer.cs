namespace Projecto_BD_Algoritmos
{
    partial class FrmConsultasClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultasClientes));
            this.dtgConsultasClientes = new System.Windows.Forms.DataGridView();
            this.cmbConsultas = new System.Windows.Forms.ComboBox();
            this.txtValores = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultasClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgConsultasClientes
            // 
            this.dtgConsultasClientes.AllowUserToAddRows = false;
            this.dtgConsultasClientes.AllowUserToDeleteRows = false;
            this.dtgConsultasClientes.AllowUserToOrderColumns = true;
            this.dtgConsultasClientes.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dtgConsultasClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgConsultasClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConsultasClientes.Location = new System.Drawing.Point(13, 13);
            this.dtgConsultasClientes.MultiSelect = false;
            this.dtgConsultasClientes.Name = "dtgConsultasClientes";
            this.dtgConsultasClientes.Size = new System.Drawing.Size(502, 425);
            this.dtgConsultasClientes.TabIndex = 0;
            // 
            // cmbConsultas
            // 
            this.cmbConsultas.FormattingEnabled = true;
            this.cmbConsultas.ItemHeight = 13;
            this.cmbConsultas.Items.AddRange(new object[] {
            "Nombre de los productos y sus precios",
            "Producto, precio y marca",
            "Ver los productos que se ajustan al presupuesto",
            "Producto y descripcion",
            "Producto y su categoria"});
            this.cmbConsultas.Location = new System.Drawing.Point(565, 50);
            this.cmbConsultas.Name = "cmbConsultas";
            this.cmbConsultas.Size = new System.Drawing.Size(200, 21);
            this.cmbConsultas.TabIndex = 1;
            this.cmbConsultas.SelectedIndexChanged += new System.EventHandler(this.cmbConsultas_SelectedIndexChanged);
            // 
            // txtValores
            // 
            this.txtValores.Location = new System.Drawing.Point(565, 146);
            this.txtValores.Name = "txtValores";
            this.txtValores.Size = new System.Drawing.Size(200, 20);
            this.txtValores.TabIndex = 2;
            this.txtValores.Visible = false;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(625, 188);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 3;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Visible = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // FrmConsultasClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 455);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txtValores);
            this.Controls.Add(this.cmbConsultas);
            this.Controls.Add(this.dtgConsultasClientes);
            this.Name = "FrmConsultasClientes";
            this.Text = "FrmConsultasClientes";
            this.Load += new System.EventHandler(this.FrmConsultasClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultasClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgConsultasClientes;
        private System.Windows.Forms.ComboBox cmbConsultas;
        private System.Windows.Forms.TextBox txtValores;
        private System.Windows.Forms.Button btnInsertar;
    }
}