namespace AppdeConsultasMiamor
{
    partial class Form2
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
            this.BtnCrearCarpetas = new System.Windows.Forms.Button();
            this.BtnCerrarF2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCrearCarpetas
            // 
            this.BtnCrearCarpetas.Location = new System.Drawing.Point(12, 12);
            this.BtnCrearCarpetas.Name = "BtnCrearCarpetas";
            this.BtnCrearCarpetas.Size = new System.Drawing.Size(129, 59);
            this.BtnCrearCarpetas.TabIndex = 0;
            this.BtnCrearCarpetas.Text = "Crea Carpetas PDF XML";
            this.BtnCrearCarpetas.UseVisualStyleBackColor = true;
            this.BtnCrearCarpetas.Click += new System.EventHandler(this.BtnCrearCarpetas_Click);
            // 
            // BtnCerrarF2
            // 
            this.BtnCerrarF2.Location = new System.Drawing.Point(6, 413);
            this.BtnCerrarF2.Name = "BtnCerrarF2";
            this.BtnCerrarF2.Size = new System.Drawing.Size(135, 59);
            this.BtnCerrarF2.TabIndex = 1;
            this.BtnCerrarF2.Text = "Cerrar";
            this.BtnCerrarF2.UseVisualStyleBackColor = true;
            this.BtnCerrarF2.Click += new System.EventHandler(this.BtnCerrarF2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppdeConsultasMiamor.Properties.Resources.animalitos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(887, 484);
            this.Controls.Add(this.BtnCerrarF2);
            this.Controls.Add(this.BtnCrearCarpetas);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCrearCarpetas;
        private System.Windows.Forms.Button BtnCerrarF2;
    }
}