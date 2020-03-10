using Compartido;
using System;
using System.ComponentModel.DataAnnotations;

namespace Modelos
{
    public class MultaCliente
    {
        public int Id { get; set; }
        public bool Deleted { get; set; }

        public DateTime FechaIniciaMulta { get; set; }

        public DateTime FechaFinalizaMulta { get; set; }

        public Cliente Cliente { get; set; }
        public int ClienteId { get; set; }

        public int EstadoMultaId { get; set; }
    }
}
