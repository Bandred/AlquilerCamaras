using System;
using System.Collections.Generic;
using System.Linq;

namespace Compartido
{
    public class SensibilidadEnum : Enumerador
    {
        public SensibilidadEnum(int id, string nombre)
            : base(id, nombre)
        {
        }

        public static SensibilidadEnum Sensibilidad50 = new SensibilidadEnum(1, "50");
        public static SensibilidadEnum Sensibilidad100 = new SensibilidadEnum(2, "100");
        public static SensibilidadEnum Sensibilidad200 = new SensibilidadEnum(3, "200");
        public static SensibilidadEnum Sensibilidad400 = new SensibilidadEnum(4, "400");
        public static SensibilidadEnum Sensibilidad800 = new SensibilidadEnum(5, "800");
        public static SensibilidadEnum Sensibilidad1600 = new SensibilidadEnum(6, "1600");

        public static IEnumerable<SensibilidadEnum> List() => new[] {
            Sensibilidad50,
            Sensibilidad100,
            Sensibilidad200,
            Sensibilidad400,
            Sensibilidad800,
            Sensibilidad1600
        };

        public static SensibilidadEnum FromString(string roleString)
        {
            return List().Single(r => String.Equals(r.Nombre, roleString, StringComparison.OrdinalIgnoreCase));
        }

        public static SensibilidadEnum FromValue(int value)
        {
            return List().Single(r => r.Id == value);
        }
    }
}
