using System.Collections.Generic;

namespace Modelos
{
    public class Marca
    {
        public int Id { get; set; }
        public bool Deleted { get; set; }
        public string Nombre { get; set; }

        public ServicioReparacion ServicioReparacion { get; set; }
        public int ServicioReparacionId { get; set; }

        public List<Modelo> Modelos { get; set; }
    }
}
