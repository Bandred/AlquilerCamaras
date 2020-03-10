using Compartido;
using System.Collections.Generic;

namespace Modelos
{
    public class Camara
    {
        public int Id { get; set; }
        public bool Deleted { get; set; }
        public string Referencia { get; set; }

        public int SoporteFlashId { get; set; }

        public int EstadoCamaraId { get; set; }

        public Modelo Modelo { get; set; }
        public int ModeloId { get; set; }

        public List<Alquiler> Alquileres { get; set; }
    }
}
