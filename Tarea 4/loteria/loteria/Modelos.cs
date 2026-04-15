using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace loteria
{
    class Jugador
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public int NumeroApostado { get; set; }
        public decimal DineroApostado { get; set; }
    }

    class ResultadoJugada
    {
        public int JugadaID { get; set; }
        public string NombreJugador { get; set; }
        public int NumeroApostado { get; set; }
        public decimal DineroApostado { get; set; }
        public int Posicion { get; set; }
        public decimal Premio { get; set; }
        public DateTime Fecha { get; set; }
    }
}