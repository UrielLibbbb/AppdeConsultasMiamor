using System;
using System.Windows.Forms;
using System.Drawing;


namespace AppdeConsultasMiamor
{
    public partial class Form1 : Form
    {
        private Authenticator authenticator = new Authenticator();

        public Form1()
        {
            InitializeComponent();
            Txtusuario.Focus();
            Txtpassword.UseSystemPasswordChar = true; // Oculta el texto ingresado en Txtpassword
            EstilizarBotones();
            this.StartPosition = FormStartPosition.CenterScreen; // Centra el formulario al iniciarse
        }

        private void EstilizarBotones()

        {
            Txtusuario.BackColor = Color.LightGray; // Color de fondo
            Txtusuario.BorderStyle = BorderStyle.FixedSingle; // Borde del campo de texto

            Txtpassword.BackColor = Color.LightGray; // Color de fondo
            Txtpassword.BorderStyle = BorderStyle.FixedSingle; // Borde del campo de texto

            // Botón de acceso
            BtnAccess.BackColor = Color.FromArgb(57, 255, 20); // Color verde brillante
            BtnAccess.FlatStyle = FlatStyle.Flat;
            BtnAccess.FlatAppearance.BorderSize = 0; // Elimina el borde del botón

            // Botón de salida
            BtnBye.BackColor = Color.FromArgb(255, 20, 20); // Color rojo brillante
            BtnBye.FlatStyle = FlatStyle.Flat;
            BtnBye.FlatAppearance.BorderSize = 0; // Elimina el borde del botón

            // Puedes ajustar otros aspectos visuales según tus preferencias, como tamaño, fuente, etc.
        }


        private void BtnAccess_Click_1(object sender, EventArgs e)
        {
            try
            {
                string usuario = Txtusuario.Text;
                string contraseña = Txtpassword.Text;

                // Validar campos vacíos
                if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contraseña))
                {
                    throw new Exception("Por favor, completa todos los campos.");
                }

                if (authenticator.AutenticarUsuario(usuario, contraseña))
                {
                    LimpiarCampos();
                    Txtusuario.Focus();

                    if (usuario == "Uriel")
                    {
                        MessageBox.Show("¡Qué pasa, mi perro!");
                        System.Media.SystemSounds.Exclamation.Play(); // Reproduce un sonido de advertencia
                    }
                    else if (usuario == "Vanessa")
                    {
                        MessageBox.Show("¡Bienvenida al amor de mi vida!");
                        System.Media.SystemSounds.Asterisk.Play(); // Reproduce un sonido de información
                    }

                    AbrirForm2(); // Llama al método para abrir Form2
                    this.Hide(); // Oculta Form1
                }
                else
                {
                    throw new Exception("Credenciales incorrectas. Intenta de nuevo.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Resto del código...

        private void LimpiarCampos()
        {
            Txtusuario.Text = "";
            Txtpassword.Text = "";
        }

        private void AbrirForm2()
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void BtnBye_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
