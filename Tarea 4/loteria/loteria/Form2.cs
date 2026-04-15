using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace loteria
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        int jugadaActualID = 1;

        List<Jugador> jugadoresActuales = new List<Jugador>();
        List<ResultadoJugada> historialGlobal = new List<ResultadoJugada>();

        public Form1()
        {
            InitializeComponent();
            ActualizarTablaJugadores();
        }

        private void btnAgregarJugador_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string numeroTexto = txtNumero.Text.Trim();
            string dineroTexto = txtDinero.Text.Trim();

            if (nombre == "")
            {
                MessageBox.Show("Escribe el nombre del jugador.", "Error");
                return;
            }

            int numero;
            if (!int.TryParse(numeroTexto, out numero) || numero < 0 || numero > 99)
            {
                MessageBox.Show("El número debe ser entre 0 y 99.", "Error");
                return;
            }

            decimal dinero;
            if (!decimal.TryParse(dineroTexto, out dinero) || dinero <= 0)
            {
                MessageBox.Show("La cantidad apostada debe ser mayor a 0.", "Error");
                return;
            }

            Jugador j = new Jugador()
            {
                ID = jugadoresActuales.Count + 1,
                Nombre = nombre,
                NumeroApostado = numero,
                DineroApostado = dinero
            };

            jugadoresActuales.Add(j);
            ActualizarTablaJugadores();

            txtNombre.Text = "";
            txtNumero.Text = "";
            txtDinero.Text = "";
            txtNombre.Focus();
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            if (jugadoresActuales.Count == 0)
            {
                MessageBox.Show("Agrega al menos un jugador antes de jugar.", "Error");
                return;
            }

            int primer = random.Next(0, 100);
            int segundo = random.Next(0, 100);
            int tercer = random.Next(0, 100);

            lblNumero1.Text = primer.ToString("D2");
            lblNumero2.Text = segundo.ToString("D2");
            lblNumero3.Text = tercer.ToString("D2");

            DateTime fechaJugada = DateTime.Now;
            List<ResultadoJugada> resultadosRonda = new List<ResultadoJugada>();

            foreach (Jugador j in jugadoresActuales)
            {
                int posicion = 0;
                decimal premio = 0;

                if (j.NumeroApostado == primer)
                {
                    posicion = 1;
                    premio = j.DineroApostado * 1000;
                }
                else if (j.NumeroApostado == segundo)
                {
                    posicion = 2;
                    premio = j.DineroApostado * 100;
                }
                else if (j.NumeroApostado == tercer)
                {
                    posicion = 3;
                    premio = j.DineroApostado * 10;
                }

                ResultadoJugada r = new ResultadoJugada()
                {
                    JugadaID = jugadaActualID,
                    NombreJugador = j.Nombre,
                    NumeroApostado = j.NumeroApostado,
                    DineroApostado = j.DineroApostado,
                    Posicion = posicion,
                    Premio = premio,
                    Fecha = fechaJugada
                };

                resultadosRonda.Add(r);
                historialGlobal.Add(r);
            }

            tablaResultados.DataSource = null;
            tablaResultados.DataSource = resultadosRonda;

            tablaHistorial.DataSource = null;
            tablaHistorial.DataSource = historialGlobal;

            MostrarMensajeGanadores(primer, segundo, tercer, resultadosRonda);

            jugadaActualID++;
            jugadoresActuales.Clear();
            ActualizarTablaJugadores();
        }
        void ActualizarTablaJugadores()
        {
            tablaJugadores.DataSource = null;
            tablaJugadores.DataSource = jugadoresActuales;
            lblCantidadJugadores.Text = "Jugadores en ronda: " + jugadoresActuales.Count;
        }

        void MostrarMensajeGanadores(int p1, int p2, int p3, List<ResultadoJugada> resultados)
        {
            string msg = "NÚMEROS SORTEADOS\n";
            msg += "1er lugar: " + p1.ToString("D2") + "  x1000 la apuesta\n";
            msg += "2do lugar: " + p2.ToString("D2") + "  x100  la apuesta\n";
            msg += "3er lugar: " + p3.ToString("D2") + "  x10   la apuesta\n\n";
            msg += "GANADORES\n";

            bool hayGanador = false;
            foreach (ResultadoJugada r in resultados)
            {
                if (r.Posicion > 0)
                {
                    msg += r.NombreJugador + " - " + r.Posicion + " lugar - Premio: $" + r.Premio.ToString("N2") + "\n";
                    hayGanador = true;
                }
            }

            if (!hayGanador)
                msg += "Ningún jugador acertó esta ronda.\n";

            MessageBox.Show(msg, "Resultado Jugada #" + jugadaActualID);

        }
    }
}