using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Prog2FinalPracticaTallerBicicleta
{
    [Serializable]
    internal class Reparacion : Servicio, IExportable
    {
        
        public double PrecioRepuesto { get; set; }
        public double horas { get; set; }

        public Reparacion(int cod, string descripcion, double precioB, double precioRespuesto) /*: base(descripcion, precioB, cod)*/
        {
            this.NroCod = cod;
            this.descripcion = descripcion;
            this.precioBase = precioB;
            PrecioRepuesto = precioRespuesto;

        }
         public Reparacion() { }
        public override double Precio()
        {
            return precioBase * horas + PrecioRepuesto;
        }

        public override string TareaRealizada()
        {
            return NroCod + " " + descripcion + " " + precioBase + " " + PrecioRepuesto;
        }
        public override string ToString()
        {
            return NroCod + " " + descripcion + " " + precioBase + " " + PrecioRepuesto;
        }

        public void Leer(string path)
        {
            string[] campos = path.Split(';');
            tipo = campos[0];
            if (tipo == "R")
            {
                this.NroCod = Convert.ToInt32(campos[1]);
                this.descripcion = campos[2];
                this.precioBase = Convert.ToDouble(campos[3]);
                PrecioRepuesto = Convert.ToDouble(campos[4]);
            }

           
        }

        public string Escribir()
        {
            throw new NotImplementedException();
        }
    }
}
