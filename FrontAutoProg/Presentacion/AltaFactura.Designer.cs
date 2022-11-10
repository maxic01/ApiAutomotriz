namespace FrontAutoProg.Presentacion
{
    partial class AltaFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaFactura));
            this.lblProxima = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboPago = new System.Windows.Forms.ComboBox();
            this.cboPedido = new System.Windows.Forms.ComboBox();
            this.cboEntrega = new System.Windows.Forms.ComboBox();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.cboVendedor = new System.Windows.Forms.ComboBox();
            this.lblTotalProductos = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.idDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProxima
            // 
            this.lblProxima.AutoSize = true;
            this.lblProxima.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProxima.ForeColor = System.Drawing.Color.White;
            this.lblProxima.Location = new System.Drawing.Point(12, 9);
            this.lblProxima.Name = "lblProxima";
            this.lblProxima.Size = new System.Drawing.Size(138, 21);
            this.lblProxima.TabIndex = 82;
            this.lblProxima.Text = "Proxima Factura:";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(280, 244);
            this.nudCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(120, 23);
            this.nudCantidad.TabIndex = 6;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtProducto
            // 
            this.txtProducto.BackColor = System.Drawing.Color.White;
            this.txtProducto.Enabled = false;
            this.txtProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtProducto.ForeColor = System.Drawing.Color.White;
            this.txtProducto.Location = new System.Drawing.Point(464, 471);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtProducto.MaxLength = 10;
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(109, 29);
            this.txtProducto.TabIndex = 80;
            this.txtProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTotal.ForeColor = System.Drawing.Color.White;
            this.txtTotal.Location = new System.Drawing.Point(464, 506);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTotal.MaxLength = 10;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(109, 29);
            this.txtTotal.TabIndex = 79;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(404, 514);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(52, 21);
            this.lblTotal.TabIndex = 78;
            this.lblTotal.Text = "Total:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(433, 1);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(110, 29);
            this.dtpFecha.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(367, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 21);
            this.label9.TabIndex = 76;
            this.label9.Text = "Fecha:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(40, 182);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 21);
            this.label8.TabIndex = 75;
            this.label8.Text = "Forma de pago";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(24, 153);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 21);
            this.label7.TabIndex = 74;
            this.label7.Text = "Medio de pedido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(20, 122);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 21);
            this.label6.TabIndex = 73;
            this.label6.Text = "Forma de entrega";
            // 
            // cboPago
            // 
            this.cboPago.FormattingEnabled = true;
            this.cboPago.Location = new System.Drawing.Point(179, 180);
            this.cboPago.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboPago.Name = "cboPago";
            this.cboPago.Size = new System.Drawing.Size(140, 23);
            this.cboPago.TabIndex = 4;
            // 
            // cboPedido
            // 
            this.cboPedido.FormattingEnabled = true;
            this.cboPedido.Location = new System.Drawing.Point(179, 149);
            this.cboPedido.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboPedido.Name = "cboPedido";
            this.cboPedido.Size = new System.Drawing.Size(140, 23);
            this.cboPedido.TabIndex = 3;
            // 
            // cboEntrega
            // 
            this.cboEntrega.FormattingEnabled = true;
            this.cboEntrega.Location = new System.Drawing.Point(179, 118);
            this.cboEntrega.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboEntrega.Name = "cboEntrega";
            this.cboEntrega.Size = new System.Drawing.Size(140, 23);
            this.cboEntrega.TabIndex = 2;
            // 
            // cboCliente
            // 
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(179, 87);
            this.cboCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(140, 23);
            this.cboCliente.TabIndex = 1;
            // 
            // cboVendedor
            // 
            this.cboVendedor.FormattingEnabled = true;
            this.cboVendedor.Location = new System.Drawing.Point(179, 55);
            this.cboVendedor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboVendedor.Name = "cboVendedor";
            this.cboVendedor.Size = new System.Drawing.Size(140, 23);
            this.cboVendedor.TabIndex = 0;
            // 
            // lblTotalProductos
            // 
            this.lblTotalProductos.AutoSize = true;
            this.lblTotalProductos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalProductos.ForeColor = System.Drawing.Color.White;
            this.lblTotalProductos.Location = new System.Drawing.Point(323, 479);
            this.lblTotalProductos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalProductos.Name = "lblTotalProductos";
            this.lblTotalProductos.Size = new System.Drawing.Size(133, 21);
            this.lblTotalProductos.TabIndex = 10;
            this.lblTotalProductos.Text = "Total Productos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(280, 220);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 21);
            this.label4.TabIndex = 66;
            this.label4.Text = "Cantidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 219);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 65;
            this.label1.Text = "Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(80, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 64;
            this.label2.Text = "Vendedor";
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(146, 473);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(134, 52);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(12, 471);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(126, 57);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click_1);
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.AllowUserToDeleteRows = false;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDetalle,
            this.producto,
            this.Precio,
            this.cantidad,
            this.acciones});
            this.dgvDetalles.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDetalles.Location = new System.Drawing.Point(24, 291);
            this.dgvDetalles.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.RowHeadersWidth = 51;
            this.dgvDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalles.Size = new System.Drawing.Size(549, 162);
            this.dgvDetalles.TabIndex = 10;
            this.dgvDetalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalles_CellContentClick_1);
            // 
            // idDetalle
            // 
            this.idDetalle.HeaderText = "Column1";
            this.idDetalle.MinimumWidth = 6;
            this.idDetalle.Name = "idDetalle";
            this.idDetalle.ReadOnly = true;
            this.idDetalle.Visible = false;
            this.idDetalle.Width = 125;
            // 
            // producto
            // 
            this.producto.HeaderText = "Producto";
            this.producto.MinimumWidth = 6;
            this.producto.Name = "producto";
            this.producto.ReadOnly = true;
            this.producto.Width = 125;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio Unitario";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // acciones
            // 
            this.acciones.HeaderText = "Acciones";
            this.acciones.MinimumWidth = 6;
            this.acciones.Name = "acciones";
            this.acciones.ReadOnly = true;
            this.acciones.Text = "Quitar";
            this.acciones.UseColumnTextForButtonValue = true;
            this.acciones.Width = 125;
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(445, 223);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(128, 57);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // cboProducto
            // 
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Location = new System.Drawing.Point(24, 243);
            this.cboProducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(201, 23);
            this.cboProducto.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(100, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 21);
            this.label3.TabIndex = 59;
            this.label3.Text = "Cliente";
            // 
            // AltaFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(590, 547);
            this.Controls.Add(this.lblProxima);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboPago);
            this.Controls.Add(this.cboPedido);
            this.Controls.Add(this.cboEntrega);
            this.Controls.Add(this.cboCliente);
            this.Controls.Add(this.cboVendedor);
            this.Controls.Add(this.lblTotalProductos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dgvDetalles);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cboProducto);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AltaFactura";
            this.Text = "Alta Factura";
            this.Load += new System.EventHandler(this.AltaFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblProxima;
        private NumericUpDown nudCantidad;
        private TextBox txtProducto;
        private TextBox txtTotal;
        private Label lblTotal;
        private DateTimePicker dtpFecha;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private ComboBox cboPago;
        private ComboBox cboPedido;
        private ComboBox cboEntrega;
        private ComboBox cboCliente;
        private ComboBox cboVendedor;
        private Label lblTotalProductos;
        private Label label4;
        private Label label1;
        private Label label2;
        private Button btnCancelar;
        private Button btnAceptar;
        private DataGridView dgvDetalles;
        private DataGridViewTextBoxColumn idDetalle;
        private DataGridViewTextBoxColumn producto;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewButtonColumn acciones;
        private Button btnAgregar;
        private ComboBox cboProducto;
        private Label label3;
    }
}