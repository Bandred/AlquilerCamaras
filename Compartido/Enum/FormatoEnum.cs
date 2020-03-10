using System;
using System.Collections.Generic;
using System.Linq;

namespace Compartido
{
    public class FormatoEnum : Enumerador
    {
        public FormatoEnum(int id, string nombre)
            : base(id, nombre)
        {
        }

        public static FormatoEnum Formato35mm = new FormatoEnum(1, "35 mm");
        public static FormatoEnum Formato110mm = new FormatoEnum(2, "110 mm");
        public static FormatoEnum Formato120mm = new FormatoEnum(3, "120 mm");

        public static IEnumerable<FormatoEnum> List() => new[] {
            Formato35mm,
            Formato110mm,
            Formato120mm
        };

        public static FormatoEnum FromString(string roleString)
        {
            return List().Single(r => String.Equals(r.Nombre, roleString, StringComparison.OrdinalIgnoreCase));
        }

        public static FormatoEnum FromValue(int value)
        {
            return List().Single(r => r.Id == value);
        }
    }
}
