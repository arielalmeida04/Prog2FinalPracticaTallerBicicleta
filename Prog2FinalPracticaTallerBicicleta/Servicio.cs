using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2FinalPracticaTallerBicicleta
{
    [Serializable]
    internal abstract class Servicio:IComparable<Servicio>
    {
        
        public string tipo {  get; set; }
        public int NroCod {  get; set; }

        protected string descripcion;

        protected double precioBase;

        //public Servicio(string descripcion, double precioBase, int nroCod)
        //{
        //    this.descripcion = descripcion;
        //    this.precioBase = precioBase;
        //    this.NroCod = nroCod;
        //}

        public abstract double Precio();
        public abstract string TareaRealizada();

        public int CompareTo(Servicio other)
        {
            return this.NroCod.CompareTo(other.NroCod);
        }

      
    }
}
