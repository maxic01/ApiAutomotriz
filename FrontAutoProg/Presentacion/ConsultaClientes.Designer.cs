namespace FrontAutoProg.Presentacion
{
    partial class ConsultaClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaClientes));
            this.label4 = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNroTel = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(572, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 21);
            this.label4.TabIndex = 23;
            this.label4.Text = "Altura";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(655, 230);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(146, 23);
            this.txtAltura.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(581, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "Calle";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(655, 201);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(146, 23);
            this.txtCalle.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(552, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Telefono";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(487, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 63);
            this.label1.TabIndex = 18;
            this.label1.Text = "Esta habilitado para modificar los siguientes campos:\r\n(Telefono, Calle, Altura)." +
    " Luego de modificar el campo\r\npresione editar para confirmar.";
            // 
            // txtNroTel
            // 
            this.txtNroTel.Location = new System.Drawing.Point(655, 172);
            this.txtNroTel.Name = "txtNroTel";
            this.txtNroTel.Size = new System.Drawing.Size(146, 23);
            this.txtNroTel.TabIndex = 0;
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(159, 334);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(141, 49);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(343, 362);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(141, 49);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrar.Image")));
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrar.Location = new System.Drawing.Point(25, 334);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(141, 49);
            this.btnBorrar.TabIndex = 4;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click_1);
            // 
            // btnConsultar
            // 
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(343, 307);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(141, 49);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click_1);
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCliente.Location = new System.Drawing.Point(25, 22);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.RowTemplate.Height = 25;
            this.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCliente.Size = new System.Drawing.Size(459, 279);
            this.dgvCliente.TabIndex = 12;
            this.dgvCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellContentClick);
            // 
            // ConsultaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(919, 429);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNroTel);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dgvCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultaClientes";
            this.Text = "Consulta Clientes";
            this.Load += new System.EventHandler(this.ConsultaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label4;
        private TextBox txtAltura;
        private Label label3;
        private TextBox txtCalle;
        private Label label2;
        private Label label1;
        private TextBox txtNroTel;
        private Button btnEditar;
        private Button btnCancelar;
        private Button btnBorrar;
        private Button btnConsultar;
        private DataGridView dgvCliente;
    }
}