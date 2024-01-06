using System;
using System.Windows.Forms;
using System.Drawing;

namespace AppdeConsultasMiamor
{
    public partial class SheetSelectionDialog : Form
    {
        public int SelectedSheetIndex { get; private set; }

        public SheetSelectionDialog(int numberOfSheets)
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;

            EstilizarFormulario();
            EstilizarBotones(BtnSelectSheet);
            EstilizarComboBox(ComboBoxHoja);
            InitializeComboBox(numberOfSheets);
        }

        private void EstilizarFormulario()
        {
            this.BackColor = Color.FromArgb(240, 240, 240);
            // Otros estilos según tus preferencias
        }

        private void EstilizarBotones(Button button)
        {
            button.BackColor = Color.FromArgb(42, 157, 143); // Color personalizado
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.ForeColor = Color.White; // Texto en color blanco para contraste
            button.Font = new Font("Arial", 10, FontStyle.Regular);
            // Otros ajustes visuales si es necesario
        }

        private void EstilizarComboBox(ComboBox comboBox)
        {
            comboBox.BackColor = Color.White;
            comboBox.FlatStyle = FlatStyle.Flat;
            comboBox.ForeColor = Color.Black; // Color del texto
            comboBox.Font = new Font("Arial", 9, FontStyle.Regular);
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList; // Evita que se pueda editar
            // Otros ajustes visuales si es necesario
        }

        private void InitializeComboBox(int numberOfSheets)
        {
            for (int i = 0; i < numberOfSheets; i++)
            {
                ComboBoxHoja.Items.Add($"Hoja {i + 1}");
            }
        }

        private void BtnSelectSheet_Click_1(object sender, EventArgs e)
        {
            if (ComboBoxHoja.SelectedIndex >= 0)
            {
                SelectedSheetIndex = ComboBoxHoja.SelectedIndex;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una hoja.");
            }
        }
    }
}
