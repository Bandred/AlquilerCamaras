using System.Collections.Generic;

namespace Modelos
{
    public class ServicioReparacion
    {
        public int Id { get; set; }
        public bool Deleted { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        public List<Marca> Marcas { get; set; }
    }
}