using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog2FinalPracticaTallerBicicleta
{
    public partial class Form1 : Form
    {
        Stack<Ticket> listaTickets = new Stack<Ticket>();
        Ticket sisteTicket;
        List<Servicio> listaServicios = new List<Servicio>();
        

        public Form1()
        {
            InitializeComponent();
            listaServicios.Add(new Mantenimiento(100,"Mantenimiento PC",1000));
            listaServicios.Add(new Reparacion(200,"Reparacion componetes PC",2000,5000));

            foreach (Servicio item in listaServicios)
            {
                lbServicios.Items.Add(item);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileStream fs = null;
            BinaryFormatter bf = null;
            try
            {
                fs = new FileStream("tickets.dat",FileMode.OpenOrCreate,FileAccess.Read);
                bf = new BinaryFormatter();

                listaTickets = bf.Deserialize(fs) as Stack<Ticket>;
            }
            catch (Exception zz)
            {

                MessageBox.Show(zz.Message);
            }
            finally
            {
                if (fs != null) fs.Close();
            }
        
        }

        private void bttCrearCliente_Click(object sender, EventArgs e)
        {
            try
            {
                AgreagarCliente ag = new AgreagarCliente();
                if (ag.ShowDialog() == DialogResult.OK)
                {
                    string nombre = ag.txbNombre.Text;
                    long cuit = Convert.ToInt64(ag.txbCuit.Text);

                    sisteTicket = new Ticket(nombre, cuit);
                }
                ag.Dispose();
            }
            catch (Exception ez)
            {

                MessageBox.Show(ez.Message);
            }
         
        }

        private void bttAgregarServicio_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (rbMantenimiento.Checked)
                {
                    Mantenimiento servicioSelect = lbServicios.SelectedItem as Mantenimiento;

                    if (cbFeriado.Checked)
                    {
                        double extra = Convert.ToDouble(txbExtra.Text);
                        servicioSelect.PorcentajeExtra(extra);
                        sisteTicket.AgregarServicio(servicioSelect);
                        MessageBox.Show("Precio: "+servicioSelect.Precio());
                        
                    }
                    else
                    {
                        
                        MessageBox.Show(" Se agrego el Mantenimiento con precio: " + servicioSelect.Precio());
                        sisteTicket.AgregarServicio(servicioSelect);

                    }
                }
                
                if (rbReparacion.Checked)
                {
                    Reparacion servicioSelect = lbServicios.SelectedItem as Reparacion;
                    int hora = Convert.ToInt32(txbHoras.Text);
                    servicioSelect.horas = hora;
                    sisteTicket.AgregarServicio(servicioSelect);
                    MessageBox.Show(" Se agrego la Reparacion con precio: " + servicioSelect.Precio());
                    

                }
            
            }
            catch (Exception ez)
            {

                MessageBox.Show(ez.Message);
            }
        }

        private void bttQuitarServicio_Click(object sender, EventArgs e)
        {
            try
            {
                int cod = Convert.ToInt32(txbNroCodigo.Text);
               MessageBox.Show( "Se quito el servicio: "+sisteTicket.QuitarServicio(cod));
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void bttPrecioFinal_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("El precio final es: "+sisteTicket.PrecioFinal());
                MessageBox.Show("" + sisteTicket.ToString());
                listaTickets.Push(sisteTicket);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            FileStream fs = null;
            BinaryFormatter bf = null;
            try
            {
                fs = new FileStream("tickets.dat",FileMode.Create,FileAccess.Write);
                bf = new BinaryFormatter(); 

                bf.Serialize(fs, listaTickets);
            }
            catch (Exception zz)
            {

                MessageBox.Show(zz.Message);
            }
        }

        private void bttExportarTickets_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Exportar Tickets";
            saveFileDialog1.Filter = "listaTickets csv|*.csv";

            if (saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                FileStream fs= null;
                StreamWriter sw=null;
                string path = saveFileDialog1.FileName;
                try
                {
                    fs = new FileStream(path, FileMode.CreateNew, FileAccess.Write);
                    sw = new StreamWriter(fs);


                    string linea = $"nro;cuit,nombrecliente;fechahora;monto";
                    sw.WriteLine(linea);

                    foreach (Ticket item in listaTickets.ToList())
                    {
                      sw.WriteLine(item.Escribir());
                    }
                }
                catch (Exception)
                {

                    throw;
                }

                finally 
                {
                    if (fs!=null)
                    {
                        if (sw!=null)
                        {
                            sw.Close();
                            fs.Close();
                        }
                    }
                }
            }
        }

        private void bttImporarServicios_Click(object sender, EventArgs e)
        {
          


            openFileDialog1.Title = "Importación de servicios";
            openFileDialog1.Filter = "archivos csv|*.csv";
            FileStream fs = null;
            StreamReader sr = null;
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                
            
                try
                {
                    fs = new FileStream(path, FileMode.Open,FileAccess.Read);
                    sr = new StreamReader(fs);

                   
                     listaServicios.Clear();

                    while (!sr.EndOfStream) 
                    { 
                        string linea = sr.ReadLine();

                        Mantenimiento m =  new Mantenimiento();

                        m.Leer(linea);
                        if (m.tipo=="M")
                        {
                            listaServicios.Add(m);
                            listBox1.Items.Add(m);
                        }
                        

                        Reparacion r = new Reparacion();
                        r.Leer(linea);
                        if (r.tipo=="R")
                        {
                            listBox1.Items.Add(r);
                            listaServicios.Add(r);
                        }
                       

                    }
                  


                }

                catch (Exception)
                {

                    throw;
                }

                finally
                {
                    if (sr != null) sr.Close();
                    if (fs != null) fs.Close();
                }
            }
           
            
        }
    }
}
