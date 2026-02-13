using Microsoft.Data.Sqlite;
using System;
using System.Windows.Forms;

namespace Loteria_2
{

    public partial class Form1 : Form
    {
        Random random = new Random();
        string connectionString = "Data Source=loteria.db";
        public Form1()
        {
            InitializeComponent();
            SQLitePCL.Batteries.Init();
            Base_De_Datos();
        }

        void Base_De_Datos()
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText =
                @"CREATE TABLE IF NOT EXISTS Numeros (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Numero1 INTEGER,
                    Numero2 INTEGER,
                    Numero3 INTEGER
            );";
                command.ExecuteNonQuery();
            }
        }

        private void Boton_Click(object sender, EventArgs e)
        {
            int n1 = random.Next(0, 10);
            int n2 = random.Next(0, 10);
            int n3 = random.Next(0, 10);

            lblNum1.Text = n1.ToString();
            lblNum2.Text = n2.ToString();
            lblNum3.Text = n3.ToString();

            Guardar_Numeros(n1, n2, n3);

        }

        void Guardar_Numeros(int n1, int n2, int n3)
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText =
                @"INSERT INTO Numeros (Numero1, Numero2, Numero3)
                    VALUES ($n1, $n2, $n3);";

                command.Parameters.AddWithValue("$n1", n1);
                command.Parameters.AddWithValue("$n2", n2);
                command.Parameters.AddWithValue("$n3", n3);

                command.ExecuteNonQuery();
            }
        }
    }
}
