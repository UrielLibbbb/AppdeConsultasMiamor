namespace AppdeConsultasMiamor
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Txtusuario = new System.Windows.Forms.TextBox();
            this.Txtpassword = new System.Windows.Forms.TextBox();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblContrasena = new System.Windows.Forms.Label();
            this.BtnAccess = new System.Windows.Forms.Button();
            this.BtnBye = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txtusuario
            // 
            this.Txtusuario.Location = new System.Drawing.Point(27, 120);
            this.Txtusuario.Name = "Txtusuario";
            this.Txtusuario.Size = new System.Drawing.Size(208, 20);
            this.Txtusuario.TabIndex = 0;
            // 
            // Txtpassword
            // 
            this.Txtpassword.Location = new System.Drawing.Point(27, 169);
            this.Txtpassword.Name = "Txtpassword";
            this.Txtpassword.Size = new System.Drawing.Size(208, 20);
            this.Txtpassword.TabIndex = 1;
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.LblUsuario.Font = new System.Drawing.Font("This side up", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.ForeColor = System.Drawing.Color.Fuchsia;
            this.LblUsuario.Location = new System.Drawing.Point(101, 97);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(74, 20);
            this.LblUsuario.TabIndex = 2;
            this.LblUsuario.Text = "Usuario";
            // 
            // LblContrasena
            // 
            this.LblContrasena.AutoSize = true;
            this.LblContrasena.BackColor = System.Drawing.Color.Transparent;
            this.LblContrasena.Font = new System.Drawing.Font("This side up", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContrasena.ForeColor = System.Drawing.Color.Fuchsia;
            this.LblContrasena.Location = new System.Drawing.Point(86, 146);
            this.LblContrasena.Name = "LblContrasena";
            this.LblContrasena.Size = new System.Drawing.Size(110, 20);
            this.LblContrasena.TabIndex = 3;
            this.LblContrasena.Text = "Contraseña";
            // 
            // BtnAccess
            // 
            this.BtnAccess.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAccess.BackgroundImage")));
            this.BtnAccess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAccess.Font = new System.Drawing.Font("This side up", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAccess.Location = new System.Drawing.Point(27, 212);
            this.BtnAccess.Name = "BtnAccess";
            this.BtnAccess.Size = new System.Drawing.Size(106, 71);
            this.BtnAccess.TabIndex = 4;
            this.BtnAccess.Text = "Aceptar";
            this.BtnAccess.UseVisualStyleBackColor = true;
            this.BtnAccess.Click += new System.EventHandler(this.BtnAccess_Click_1);
            // 
            // BtnBye
            // 
            this.BtnBye.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnBye.BackgroundImage")));
            this.BtnBye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBye.Font = new System.Drawing.Font("This side up", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBye.Location = new System.Drawing.Point(129, 212);
            this.BtnBye.Name = "BtnBye";
            this.BtnBye.Size = new System.Drawing.Size(106, 71);
            this.BtnBye.TabIndex = 5;
            this.BtnBye.Text = "Cerrar";
            this.BtnBye.UseVisualStyleBackColor = true;
            this.BtnBye.Click += new System.EventHandler(this.BtnBye_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppdeConsultasMiamor.Properties.Resources.Más_actual___Pantalla__gatos_fondos_amor__Conceptos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(280, 328);
            this.Controls.Add(this.BtnBye);
            this.Controls.Add(this.BtnAccess);
            this.Controls.Add(this.LblContrasena);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.Txtpassword);
            this.Controls.Add(this.Txtusuario);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Vanessa y Uriel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txtusuario;
        private System.Windows.Forms.TextBox Txtpassword;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label LblContrasena;
        private System.Windows.Forms.Button BtnAccess;
        private System.Windows.Forms.Button BtnBye;
    }
}

