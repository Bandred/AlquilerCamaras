using System.Collections.Generic;

namespace Modelos
{
    public class Modelo
    {
        public int Id { get; set; }
        public bool Deleted { get; set; }
        public string Nombre { get; set; }

        public Marca Marca { get; set; }
        public int MarcaId { get; set; }

        public List<Camara> Camaras { get; set; }
        public List<ModeloPelicula> ModelosPeliculas { get; set; }
    }
}
