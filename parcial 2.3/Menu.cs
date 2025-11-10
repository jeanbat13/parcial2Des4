using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parcial_2._3
{
    public partial class Menu : Form
    {
        private int userId;
        private string userName;
        private string nombreReal;

        public Menu(int id, string nombre)
        {
            InitializeComponent();
            userId = id;
            userName = nombre;
            this.Load += MenuForm_Load;
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            ObtenerNombreReal();
            lblname.Text = "Bienvenido! " + nombreReal;
            CargarDatosUsuario();
        }

        private void ObtenerNombreReal()
        {
            string connectionString = "server=localhost;user=root;password=1GS126;database=parcial2;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT nombre FROM usuarios WHERE id = @id;";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", userId);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                        nombreReal = result.ToString();
                    else
                        nombreReal = userName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener nombre del usuario: " + ex.Message);
                    nombreReal = userName;
                }
            }
        }

        private void CargarDatosUsuario()
        {
            string connectionString = "server=localhost;user=root;password=1GS126;database=parcial2;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"SELECT numeroCuenta, saldo 
                                     FROM cuentas 
                                     WHERE usuario_id = @id LIMIT 1;";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", userId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblCuenta.Text = "Cuenta: " + reader["numeroCuenta"].ToString();
                            lblSaldo.Text = "Saldo: $" + reader["saldo"].ToString();
                        }
                        else
                        {
                            lblCuenta.Text = "Cuenta: no encontrada";
                            lblSaldo.Text = "Saldo: $0.00";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos: " + ex.Message, "Error SQL");
                }
            }
        }

        private void btnTransaccion_Click(object sender, EventArgs e)
        {
            TransaccionesMenu transaccionesMenu = new TransaccionesMenu();
            transaccionesMenu.Show();
            this.Hide();
        }
    }
}