using System;
using System.Collections.Generic;
using System.Linq;

namespace Compartido
{
    public class EstadoMultaEnum : Enumerador
    {
        public EstadoMultaEnum(int id, string nombre)
            : base(id, nombre)
        {
        }

        public static EstadoMultaEnum Activa = new EstadoMultaEnum(1, "Activa");
        public static EstadoMultaEnum Inactiva = new EstadoMultaEnum(2, "Inactiva");

        public static IEnumerable<EstadoMultaEnum> List() => new[] {
            Activa,
            Inactiva
        };

        public static EstadoMultaEnum FromString(string roleString)
        {
            return List().Single(r => String.Equals(r.Nombre, roleString, StringComparison.OrdinalIgnoreCase));
        }

        public static EstadoMultaEnum FromValue(int value)
        {
            return List().Single(r => r.Id == value);
        }
    }
}
