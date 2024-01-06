using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppdeConsultasMiamor
{
    public partial class Form2 : Form
    {
        public Class1 class1Instance;
        public Form3 form3Instance; // This field stores an instance of Form3

        public Form2()
        {
            InitializeComponent();

            // Subscribe to button click events
            BtnCrearCarpetas.Click += BtnCrearCarpetas_Click;
            BtnCerrarF2.Click += BtnCerrarF2_Click;

            // Initialize class1Instance using 'this' that references the current instance of Form2
            class1Instance = new Class1(this);

            // Hide the form border and control box
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;

            // Set the background color of the form to white
            this.BackColor = Color.White;

            // Set a clean and minimalist font for the buttons
            BtnCrearCarpetas.Font = new Font("Arial", 10, FontStyle.Regular);
            BtnCerrarF2.Font = new Font("Arial", 10, FontStyle.Regular);

            // Set flat style for the buttons
            BtnCrearCarpetas.FlatStyle = FlatStyle.Flat;
            BtnCerrarF2.FlatStyle = FlatStyle.Flat;

            // Set background colors for the buttons
            BtnCrearCarpetas.BackColor = Color.FromArgb(42, 157, 143); // Custom color
            BtnCerrarF2.BackColor = Color.FromArgb(255, 64, 129); // Custom color

            // Set text for the buttons
            BtnCrearCarpetas.Text = "Crear Carpetas";
            BtnCerrarF2.Text = "Cerrar";

            // Subscribe again to button click events (double subscriptions, it's better to remove the duplicate subscriptions)
            BtnCrearCarpetas.Click += BtnCrearCarpetas_Click;
            BtnCerrarF2.Click += BtnCerrarF2_Click;
        }

        private void BtnCrearCarpetas_Click(object sender, EventArgs e)
        {
            AbrirForm3(); // Open Form3
        }

        private void AbrirForm3()
        {
            // Check if an instance of Form3 already exists
            if (form3Instance == null || form3Instance.IsDisposed)
            {
                form3Instance = new Form3();
                form3Instance.Show(); // If it doesn't exist, create a new instance and show it
            }
            else
            {
                form3Instance.BringToFront(); // If it exists, bring it to the front
            }
        }

        private void BtnCerrarF2_Click(object sender, EventArgs e)
        {
            // Cerrar el formulario actual (Form2)
            this.Close();

            // Mostrar o crear una nueva instancia de Form1
            Form1 form1Instance = new Form1();
            form1Instance.Show();

            // Liberar recursos o realizar otras acciones si es necesario al cerrar Form2 y mostrar Form1
        }

    }
}
