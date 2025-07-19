using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2FinalPracticaTallerBicicleta
{
    internal interface IExportable
    {
         void Leer(string path);
         string Escribir();
    }
}
