using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2FinalPracticaTallerBicicleta
{
    [Serializable]
    internal class Ticket:IExportable
    {
        Cliente unCliente;
        List<Servicio> listaServicios = new List<Servicio>();
        static int nroOrden;
        DateTime fechaHora;
        public int nro;

        public Ticket(string nombre, long cuit) 
        {
            unCliente = new Cliente(cuit, nombre);
            fechaHora = DateTime.Now;
            nroOrden++;
            nro = nroOrden;
        }
        public void AgregarServicio(Servicio tarea)
        {
            if (tarea != null) listaServicios.Add(tarea);
        }
        public Servicio QuitarServicio(int nroOrden)
        {
            Ordenar();
            Servicio buscar = new Mantenimiento(nroOrden,"",0);

            int indice = listaServicios.BinarySearch(buscar);

            if (indice >= 0) 
            { 
                Servicio encontrado = listaServicios[indice];
                return encontrado;
            }
            return null;
        }

       public double PrecioFinal()
        {
            double acumulador = 0;
            foreach (Servicio item in listaServicios)
            {
                acumulador += item.Precio();
            }
            return acumulador;
        }
   
        public void Ordenar()
        {
            listaServicios.Sort();
        }

        public override string ToString()
        {
            return nro+";"+unCliente.ToString()+";"+fechaHora.ToString()+";" +PrecioFinal();
        }

        public void Leer(string path)
        {
            throw new NotImplementedException();
        }

        public string Escribir()
        {
            return $"{ToString()}"; 
        }
    }
}
