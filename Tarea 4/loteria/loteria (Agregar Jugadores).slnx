using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace loteria
{

    public partial class Form1 : Form
    {
        Random random = new Random();
        int idJugador = 1;

        int[] frecuencia = new int[100];

        class Jugada
        {
            public int JugadorID { get; set; }
            public int Numero1 { get; set; }
            public int Numero2 { get; set; }
            public int Numero3 { get; set; }
        }

        List<Jugada> historial = new List<Jugada>();

        public Form1()
        {
            InitializeComponent();
            tablaJugadas.DataSource = historial;
            tablaFrecuencia.AutoGenerateColumns = true;
        }

        private void boton_Click(object sender, EventArgs e)
        {
            int num1 = random.Next(0, 100);
            int num2 = random.Next(0, 100);
            int num3 = random.Next(0, 100);

            lblnumero1.Text = num1.ToString();
            lblnumero2.Text = num2.ToString();
            lblnumero3.Text = num3.ToString();

            lblJugador.Text = "Jugador ID: " + idJugador;

            Jugada nueva = new Jugada()
            {
                JugadorID = idJugador,
                Numero1 = num1,
                Numero2 = num2,
                Numero3 = num3
            };

            historial.Add(nueva);

            tablaJugadas.DataSource = null;
            tablaJugadas.DataSource = historial;

            frecuencia[num1]++;
            frecuencia[num2]++;
            frecuencia[num3]++;

            MostrarFrecuencia();

            idJugador++;
        }

        void MostrarFrecuencia()
        {
            var lista = new List<object>();

            for (int i = 0; i < 100; i++)
            {
                lista.Add(new
                {
                    Numero = i,
                    Veces = frecuencia[i]
                });
            }

            tablaFrecuencia.DataSource = null;
            tablaFrecuencia.DataSource = lista;
        }
    }
}
