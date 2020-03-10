using System;

namespace Compartido
{
    public abstract class Enumerador : IComparable
    {
        public int Id { get; private set; }
        public string Nombre { get; private set; }

        protected Enumerador() { }

        protected Enumerador(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }

        public override string ToString() => Nombre;

        public int CompareTo(object other)
        {
            return Id.CompareTo(((Enumerador)other).Id);
        }

    }
}
