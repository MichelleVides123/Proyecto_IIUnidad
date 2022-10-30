using Datos;

namespace Login
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private async void aceptarbutton_Click(object sender, EventArgs e)
        {
            if (correotextBox.Text == String.Empty)
            {
                errorProvider1.SetError(correotextBox, "Ingrese el correo de ususario");
                correotextBox.Focus();
                return;
            }
            errorProvider1.Clear();
            if (clavetextBox.Text == String.Empty)
            {
                errorProvider1.SetError(clavetextBox, "Ingrese la clave de ususario");
                clavetextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            UsuarioDatos userDatos = new UsuarioDatos();

            bool valido = await userDatos.LoginAsync(correotextBox.Text, clavetextBox.Text);

            if (valido)
            {
                menu formulario = new menu();
                Hide();
                formulario.Show();
            }
            else
            {

                MessageBox.Show("Datos incorrectos");
            }

        }
    }
}