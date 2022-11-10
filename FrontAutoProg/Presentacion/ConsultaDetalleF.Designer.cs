namespace FrontAutoProg.Presentacion
{
    partial class ConsultaDetalleF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaDetalleF));
            this.dgvDetalleF = new System.Windows.Forms.DataGridView();
            this.colFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalProductos = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboEntrega = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleF)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDetalleF
            // 
            this.dgvDetalleF.AllowUserToAddRows = false;
            this.dgvDetalleF.AllowUserToDeleteRows = false;
            this.dgvDetalleF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFactura,
            this.colProducto,
            this.colCantidad,
            this.colPrecio});
            this.dgvDetalleF.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDetalleF.Location = new System.Drawing.Point(34, 153);
            this.dgvDetalleF.Name = "dgvDetalleF";
            this.dgvDetalleF.ReadOnly = true;
            this.dgvDetalleF.RowTemplate.Height = 25;
            this.dgvDetalleF.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleF.Size = new System.Drawing.Size(560, 150);
            this.dgvDetalleF.TabIndex = 9;
            // 
            // colFactura
            // 
            this.colFactura.HeaderText = "Factura Nro";
            this.colFactura.Name = "colFactura";
            this.colFactura.ReadOnly = true;
            this.colFactura.Visible = false;
            // 
            // colProducto
            // 
            this.colProducto.HeaderText = "Producto";
            this.colProducto.Name = "colProducto";
            this.colProducto.ReadOnly = true;
            this.colProducto.Width = 200;
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            // 
            // colPrecio
            // 
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(195, 60);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(100, 23);
            this.txtCliente.TabIndex = 1;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(195, 31);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 23);
            this.txtFecha.TabIndex = 0;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCliente.ForeColor = System.Drawing.Color.White;
            this.lblCliente.Location = new System.Drawing.Point(109, 62);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(64, 21);
            this.lblCliente.TabIndex = 6;
            this.lblCliente.Text = "Cliente";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(119, 33);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(54, 21);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "Fecha";
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(176, 306);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(161, 53);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtProducto
            // 
            this.txtProducto.BackColor = System.Drawing.Color.White;
            this.txtProducto.Enabled = false;
            this.txtProducto.ForeColor = System.Drawing.Color.White;
            this.txtProducto.Location = new System.Drawing.Point(485, 307);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtProducto.MaxLength = 10;
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(109, 23);
            this.txtProducto.TabIndex = 88;
            this.txtProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.Enabled = false;
            this.txtTotal.ForeColor = System.Drawing.Color.White;
            this.txtTotal.Location = new System.Drawing.Point(485, 336);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTotal.MaxLength = 10;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(109, 23);
            this.txtTotal.TabIndex = 87;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(425, 338);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(52, 21);
            this.lblTotal.TabIndex = 86;
            this.lblTotal.Text = "Total:";
            // 
            // lblTotalProductos
            // 
            this.lblTotalProductos.AutoSize = true;
            this.lblTotalProductos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalProductos.ForeColor = System.Drawing.Color.White;
            this.lblTotalProductos.Location = new System.Drawing.Point(344, 309);
            this.lblTotalProductos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalProductos.Name = "lblTotalProductos";
            this.lblTotalProductos.Size = new System.Drawing.Size(133, 21);
            this.lblTotalProductos.TabIndex = 85;
            this.lblTotalProductos.Text = "Total Productos:";
            // 
            // btnActualizar
            // 
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(24, 306);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(146, 69);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar factura";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 21);
            this.label1.TabIndex = 90;
            this.label1.Text = "Forma de entrega";
            // 
            // cboEntrega
            // 
            this.cboEntrega.FormattingEnabled = true;
            this.cboEntrega.Location = new System.Drawing.Point(195, 89);
            this.cboEntrega.Name = "cboEntrega";
            this.cboEntrega.Size = new System.Drawing.Size(100, 23);
            this.cboEntrega.TabIndex = 2;
            // 
            // ConsultaDetalleF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(612, 379);
            this.Controls.Add(this.cboEntrega);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTotalProductos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvDetalleF);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblFecha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultaDetalleF";
            this.Text = "Consulta Detalle";
            this.Load += new System.EventHandler(this.ConsultaDetalleF_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvDetalleF;
        private TextBox txtCliente;
        private TextBox txtFecha;
        private Label lblCliente;
        private Label lblFecha;
        private Button btnCancelar;
        private TextBox txtProducto;
        private TextBox txtTotal;
        private Label lblTotal;
        private Label lblTotalProductos;
        private Button btnActualizar;
        private DataGridViewTextBoxColumn colFactura;
        private DataGridViewTextBoxColumn colProducto;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewTextBoxColumn colPrecio;
        private Label label1;
        private ComboBox cboEntrega;
    }
}