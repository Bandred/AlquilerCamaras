namespace Modelos
{
    public class ModeloPelicula
    {
        public int Id { get; set; }
        public bool Deleted { get; set; }

        public Pelicula Pelicula { get; set; }
        public int PeliculaId { get; set; }

        public Modelo Modelo { get; set; }
        public int ModeloId { get; set; }
    }
}
