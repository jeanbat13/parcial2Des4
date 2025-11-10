using MySql.Data.MySqlClient;

namespace parcial_2._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtName.Text;
            string contrasena = mtxtPass.Text;

            // Validaciones básicas
            if (usuario == "" || contrasena == "")
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string connectionString = "server=localhost;user=root;password=1GS126;database=parcial2;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT id, usuario FROM usuarios WHERE usuario = @user AND contraseña = @pass;";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@user", usuario);
                    cmd.Parameters.AddWithValue("@pass", contrasena);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int id = reader.GetInt32("id");
                            string nombre = reader.GetString("usuario");

                            MessageBox.Show("Inicio de sesión exitoso.", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Menu menu = new Menu(id, nombre);
                            menu.Show();
                            this.Hide(); 
                        }
                        else
                        {
                            MessageBox.Show("Usuario o contraseña incorrectos o no existen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de conexión: " + ex.Message);
                }

            }
        }
    }
}
