using Compartido;
using System.Collections.Generic;

namespace Modelos
{
    public class Pelicula
    {
        public int Id { get; set; }
        public bool Deleted { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public int SensibilidadId { get; set; }
        public int FormatoId { get; set; }

        public List<ModeloPelicula> ModelosPeliculas { get; set; }
    }
}
