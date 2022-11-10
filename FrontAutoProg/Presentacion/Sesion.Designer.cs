namespace TP_LAB_Part3.Presentacion
{
    partial class Sesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sesion));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_contra = new System.Windows.Forms.TextBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.chk_mostrar = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_usuario.Location = new System.Drawing.Point(13, 35);
            this.txt_usuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(352, 22);
            this.txt_usuario.TabIndex = 0;
            // 
            // txt_contra
            // 
            this.txt_contra.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_contra.Location = new System.Drawing.Point(13, 82);
            this.txt_contra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_contra.Name = "txt_contra";
            this.txt_contra.PasswordChar = '*';
            this.txt_contra.Size = new System.Drawing.Size(352, 22);
            this.txt_contra.TabIndex = 1;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_aceptar.FlatAppearance.BorderSize = 0;
            this.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aceptar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_aceptar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_aceptar.Image = ((System.Drawing.Image)(resources.GetObject("btn_aceptar.Image")));
            this.btn_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_aceptar.Location = new System.Drawing.Point(13, 136);
            this.btn_aceptar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(176, 68);
            this.btn_aceptar.TabIndex = 3;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_aceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_aceptar.UseVisualStyleBackColor = false;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.Image")));
            this.btn_cancelar.Location = new System.Drawing.Point(188, 136);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(168, 68);
            this.btn_cancelar.TabIndex = 4;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // chk_mostrar
            // 
            this.chk_mostrar.AutoSize = true;
            this.chk_mostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chk_mostrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chk_mostrar.Location = new System.Drawing.Point(13, 110);
            this.chk_mostrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chk_mostrar.Name = "chk_mostrar";
            this.chk_mostrar.Size = new System.Drawing.Size(141, 20);
            this.chk_mostrar.TabIndex = 2;
            this.chk_mostrar.Text = "Mostrar contraseña";
            this.chk_mostrar.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(775, 415);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Sesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(775, 415);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.txt_contra);
            this.Controls.Add(this.chk_mostrar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Sesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de Sesión";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Sesion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_contra;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.CheckBox chk_mostrar;
        private PictureBox pictureBox1;
    }
}