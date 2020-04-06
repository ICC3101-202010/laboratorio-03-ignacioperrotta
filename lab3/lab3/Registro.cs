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
        private List<Producto> Carro = new List<Producto>();
        
        public void VerCarro()
        {
            for (int i = 0; i < Carro.Count; i++)
            {
                Console.WriteLine(Carro[i]);
            }
        }
        public Registro(string fecha, string hora, List<Producto> Carro)
        {
            this.fecha = fecha;
            this.hora = hora;
            this.Carro = Carro;
        }

    }
}
