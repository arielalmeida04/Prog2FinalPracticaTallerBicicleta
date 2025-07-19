using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Prog2FinalPracticaTallerBicicleta
{
    [Serializable]
    internal class Cliente
    {

        public long Cuit { get; set; }
        public string Nombre { get; set; }

        public Cliente(long cuit, string nombre)
        {
            Cuit = cuit;
            Nombre = nombre;
        }

        public override string ToString()
        {
            return Nombre + " " +Cuit;
        }
    }
}
