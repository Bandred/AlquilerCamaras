using System;
using System.Collections.Generic;
using System.Linq;

namespace Compartido
{
    public class SoporteFlashEnum : Enumerador
    {
        public SoporteFlashEnum(int id, string nombre)
            : base(id, nombre)
        {
        }

        public static SoporteFlashEnum SoporteFlashSi = new SoporteFlashEnum(1, "Si");
        public static SoporteFlashEnum SoporteFlashNo = new SoporteFlashEnum(2, "No");

        public static IEnumerable<SoporteFlashEnum> List() => new[] {
            SoporteFlashSi,
            SoporteFlashNo
        };

        public static SoporteFlashEnum FromString(string roleString)
        {
            return List().Single(r => String.Equals(r.Nombre, roleString, StringComparison.OrdinalIgnoreCase));
        }

        public static SoporteFlashEnum FromValue(int value)
        {
            return List().Single(r => r.Id == value);
        }
    }
}
