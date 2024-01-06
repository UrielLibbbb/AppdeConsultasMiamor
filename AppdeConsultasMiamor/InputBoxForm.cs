using System;
using System.Windows.Forms;
using System.Drawing;

namespace AppdeConsultasMiamor
{
    public partial class InputBoxForm : Form
    {
        public string EnteredText { get; private set; }

        private Button BtnOK;
        private Button BtnCancel;
        private TextBox TextBox1;

        public InputBoxForm()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            EstilizarFormulario();
        }

        private void InitializeComponent()
        {
            this.BtnOK = new Button();
            this.BtnCancel = new Button();
            this.TextBox1 = new TextBox();
            this.SuspendLayout();

            // Botón OK
            this.BtnOK.Location = new Point(31, 158);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new Size(75, 23);
            this.BtnOK.TabIndex = 0;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new EventHandler(this.BtnOK_Click);

            // Botón Cancelar
            this.BtnCancel.Location = new Point(150, 158);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new Size(75, 23);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new EventHandler(this.BtnCancel_Click);

            // TextBox
            this.TextBox1.Location = new Point(31, 72);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new Size(194, 20);
            this.TextBox1.TabIndex = 2;

            // Formulario InputBoxForm
            this.BackgroundImage = global::AppdeConsultasMiamor.Properties.Resources.Más_actual___Pantalla__gatos_fondos_amor__Conceptos;
            this.ClientSize = new Size(284, 261);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.Name = "InputBoxForm";
            this.ResumeLayout(false);
        }

        private void EstilizarFormulario()
        {
            BtnOK.BackColor = Color.FromArgb(57, 255, 20);
            BtnOK.FlatStyle = FlatStyle.Flat;
            BtnOK.FlatAppearance.BorderSize = 0;
            BtnOK.ForeColor = Color.White;
            BtnOK.Font = new Font("Arial", 10, FontStyle.Bold);

            BtnCancel.BackColor = Color.FromArgb(255, 64, 129);
            BtnCancel.FlatStyle = FlatStyle.Flat;
            BtnCancel.FlatAppearance.BorderSize = 0;
            BtnCancel.ForeColor = Color.White;
            BtnCancel.Font = new Font("Arial", 10, FontStyle.Bold);
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            EnteredText = TextBox1.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

       
            
        
    }
}
