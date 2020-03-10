using System;
using System.ComponentModel.DataAnnotations;

namespace Modelos
{
    public class Alquiler
    {
        public int Id { get; set; }
        public bool Deleted { get; set; }

        public DateTime FechaAlquiler { get; set; }

        public Camara Camara { get; set; }
        public int CamaraId { get; set; }

        public Cliente Cliente { get; set; }
        public int ClienteId { get; set; }

        public bool Estado { get; set; }
    }
}
