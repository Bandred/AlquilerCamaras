using System;
using System.Collections.Generic;
using System.Linq;

namespace Compartido
{
    public class EstadoCamaraEnum : Enumerador
    {
        public EstadoCamaraEnum(int id, string nombre)
            : base(id, nombre)
        {
        }

        public static EstadoCamaraEnum Disponible = new EstadoCamaraEnum(1, "Disponible");
        public static EstadoCamaraEnum Alquilada = new EstadoCamaraEnum(2, "Alquilada");
        public static EstadoCamaraEnum Reparacion = new EstadoCamaraEnum(3, "Reparación");

        public static IEnumerable<EstadoCamaraEnum> List() => new[] {
            Disponible,
            Alquilada,
            Reparacion
        };

        public static EstadoCamaraEnum FromString(string roleString)
        {
            return List().Single(r => String.Equals(r.Nombre, roleString, StringComparison.OrdinalIgnoreCase));
        }

        public static EstadoCamaraEnum FromValue(int value)
        {
            return List().Single(r => r.Id == value);
        }
    }
}
