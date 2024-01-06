namespace AppdeConsultasMiamor
{
    partial class SheetSelectionDialog
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
            this.BtnSelectSheet = new System.Windows.Forms.Button();
            this.ComboBoxHoja = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnSelectSheet
            // 
            this.BtnSelectSheet.BackgroundImage = global::AppdeConsultasMiamor.Properties.Resources.icons8_botón_de_apagado;
            this.BtnSelectSheet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnSelectSheet.Location = new System.Drawing.Point(153, 125);
            this.BtnSelectSheet.Name = "BtnSelectSheet";
            this.BtnSelectSheet.Size = new System.Drawing.Size(75, 55);
            this.BtnSelectSheet.TabIndex = 1;
            this.BtnSelectSheet.Text = "Seleccionar";
            this.BtnSelectSheet.UseVisualStyleBackColor = true;
            this.BtnSelectSheet.Click += new System.EventHandler(this.BtnSelectSheet_Click_1);
            // 
            // ComboBoxHoja
            // 
            this.ComboBoxHoja.FormattingEnabled = true;
            this.ComboBoxHoja.Location = new System.Drawing.Point(26, 143);
            this.ComboBoxHoja.Name = "ComboBoxHoja";
            this.ComboBoxHoja.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxHoja.TabIndex = 2;
            // 
            // SheetSelectionDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppdeConsultasMiamor.Properties.Resources.Más_actual___Pantalla__gatos_fondos_amor__Conceptos1;
            this.ClientSize = new System.Drawing.Size(248, 240);
            this.Controls.Add(this.ComboBoxHoja);
            this.Controls.Add(this.BtnSelectSheet);
            this.Name = "SheetSelectionDialog";
            this.Text = "SheetSelectionDialog";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnSelectSheet;
        private System.Windows.Forms.ComboBox ComboBoxHoja;
    }
}