using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2FinalPracticaTallerBicicleta
{
    [Serializable]
    internal class Mantenimiento:Servicio,IExportable
    {
        private double extra=0;
        public string tipo {  get; set; }
        public Mantenimiento(int cod, string descripcion, double precioB ) /*: base(descripcion, precioB, cod)*/
        {
            this.NroCod = cod;
            this.descripcion = descripcion;
            this.precioBase = precioB;
        }

        public Mantenimiento() { }

        public void PorcentajeExtra(double extra2)
        {
            extra = (precioBase * extra2 / 100);
        }

        public override double Precio()
        {
            return precioBase + extra;
        }

        public override string TareaRealizada()
        {
            return NroCod+" "+descripcion + " " +precioBase;
        }
        public override string ToString()
        {
            return NroCod + " " + descripcion + " " + precioBase;
        }

        public string Escribir()
        {
            throw new NotImplementedException();
        }

        public void Leer(string path)
        {
            string[] campos = path.Split(';');
            tipo = campos[0];
            if (tipo=="M")
            {
                this.NroCod=Convert.ToInt32(campos[1]);
                this.descripcion=campos[2];
                this.precioBase=Convert.ToDouble(campos[3]);
            }
        }

    }
}
