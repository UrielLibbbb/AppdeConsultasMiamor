namespace AppdeConsultasMiamor
{
    partial class Form3
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnCargarExcel = new System.Windows.Forms.Button();
            this.BtnBye2 = new System.Windows.Forms.Button();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnCrearCarpetaMaster = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.BtnOpenFolders = new System.Windows.Forms.Button();
            this.BtnPdfXml = new System.Windows.Forms.Button();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.treeView1Dat = new System.Windows.Forms.TreeView();
            this.BtnUnirPdfPrincipal = new System.Windows.Forms.Button();
            this.txtFallas = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog3 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BtnCargarExcel
            // 
            this.BtnCargarExcel.Location = new System.Drawing.Point(0, 6);
            this.BtnCargarExcel.Name = "BtnCargarExcel";
            this.BtnCargarExcel.Size = new System.Drawing.Size(150, 97);
            this.BtnCargarExcel.TabIndex = 0;
            this.BtnCargarExcel.Text = "CargarExcel";
            this.BtnCargarExcel.UseVisualStyleBackColor = true;
            this.BtnCargarExcel.Click += new System.EventHandler(this.BtnCargarExcel_Click);
            // 
            // BtnBye2
            // 
            this.BtnBye2.Location = new System.Drawing.Point(0, 369);
            this.BtnBye2.Name = "BtnBye2";
            this.BtnBye2.Size = new System.Drawing.Size(150, 48);
            this.BtnBye2.TabIndex = 1;
            this.BtnBye2.Text = "Cerrar2";
            this.BtnBye2.UseVisualStyleBackColor = true;
            this.BtnBye2.Click += new System.EventHandler(this.BtnBye2_Click);
            // 
            // DataGridView1
            // 
            this.DataGridView1.BackgroundColor = System.Drawing.Color.Fuchsia;
            this.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(169, 6);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DataGridView1.Size = new System.Drawing.Size(748, 411);
            this.DataGridView1.TabIndex = 2;
            this.DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // BtnCrearCarpetaMaster
            // 
            this.BtnCrearCarpetaMaster.Location = new System.Drawing.Point(0, 109);
            this.BtnCrearCarpetaMaster.Name = "BtnCrearCarpetaMaster";
            this.BtnCrearCarpetaMaster.Size = new System.Drawing.Size(150, 23);
            this.BtnCrearCarpetaMaster.TabIndex = 3;
            this.BtnCrearCarpetaMaster.Text = "Master";
            this.BtnCrearCarpetaMaster.UseVisualStyleBackColor = true;
            this.BtnCrearCarpetaMaster.Click += new System.EventHandler(this.BtnCrearCarpetaMaster_Click);
            // 
            // BtnOpenFolders
            // 
            this.BtnOpenFolders.Location = new System.Drawing.Point(0, 326);
            this.BtnOpenFolders.Name = "BtnOpenFolders";
            this.BtnOpenFolders.Size = new System.Drawing.Size(150, 23);
            this.BtnOpenFolders.TabIndex = 5;
            this.BtnOpenFolders.Text = "Abrir Folder";
            this.BtnOpenFolders.UseVisualStyleBackColor = true;
            this.BtnOpenFolders.Click += new System.EventHandler(this.BtnOpenFolders_Click);
            // 
            // BtnPdfXml
            // 
            this.BtnPdfXml.Location = new System.Drawing.Point(0, 138);
            this.BtnPdfXml.Name = "BtnPdfXml";
            this.BtnPdfXml.Size = new System.Drawing.Size(150, 23);
            this.BtnPdfXml.TabIndex = 6;
            this.BtnPdfXml.Text = "PDF_XML";
            this.BtnPdfXml.UseVisualStyleBackColor = true;
            this.BtnPdfXml.Click += new System.EventHandler(this.BtnPdfXml_Click_1);
            // 
            // treeView1Dat
            // 
            this.treeView1Dat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeView1Dat.Location = new System.Drawing.Point(923, 6);
            this.treeView1Dat.Name = "treeView1Dat";
            this.treeView1Dat.Size = new System.Drawing.Size(321, 411);
            this.treeView1Dat.TabIndex = 7;
            this.treeView1Dat.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1Dat_AfterSelect);
            // 
            // BtnUnirPdfPrincipal
            // 
            this.BtnUnirPdfPrincipal.Location = new System.Drawing.Point(0, 229);
            this.BtnUnirPdfPrincipal.Name = "BtnUnirPdfPrincipal";
            this.BtnUnirPdfPrincipal.Size = new System.Drawing.Size(150, 23);
            this.BtnUnirPdfPrincipal.TabIndex = 8;
            this.BtnUnirPdfPrincipal.Text = "Unir";
            this.BtnUnirPdfPrincipal.UseVisualStyleBackColor = true;
            this.BtnUnirPdfPrincipal.Click += new System.EventHandler(this.BtnUnirPdfPrincipal_Click);
            // 
            // txtFallas
            // 
            this.txtFallas.Location = new System.Drawing.Point(0, 167);
            this.txtFallas.Name = "txtFallas";
            this.txtFallas.Size = new System.Drawing.Size(150, 20);
            this.txtFallas.TabIndex = 9;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppdeConsultasMiamor.Properties.Resources.chinese_lantern_4733367_1280;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1256, 419);
            this.Controls.Add(this.txtFallas);
            this.Controls.Add(this.BtnUnirPdfPrincipal);
            this.Controls.Add(this.treeView1Dat);
            this.Controls.Add(this.BtnPdfXml);
            this.Controls.Add(this.BtnOpenFolders);
            this.Controls.Add(this.BtnCrearCarpetaMaster);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.BtnBye2);
            this.Controls.Add(this.BtnCargarExcel);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BtnCargarExcel;
        private System.Windows.Forms.Button BtnBye2;
        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.Button BtnCrearCarpetaMaster;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        
        
        private System.Windows.Forms.Button BtnOpenFolders;
        private System.Windows.Forms.Button BtnPdfXml;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        
        private System.Windows.Forms.TreeView treeView1Dat;
        private System.Windows.Forms.Button BtnUnirPdfPrincipal;
        private System.Windows.Forms.TextBox txtFallas;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog3;
    }
}