using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace lab3
{
    public class Registro
    {
        private string fecha;
        private string hora;
        private List<Producto> Comprado = new List<Producto>();


        public Registro(string fecha, string hora, List<Producto> Comprado)
        {
            this.fecha = fecha;
            this.hora = hora;
            this.Comprado = Comprado;
        }
        public void VerComprados()
        {
            for (int i = 0; i < Comprado.Count; i++)
            {
                Console.WriteLine(Comprado[i]);
            }
        }
       
        

        

    }
}
