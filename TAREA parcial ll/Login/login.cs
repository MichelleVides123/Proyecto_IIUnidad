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

        }
    }
}