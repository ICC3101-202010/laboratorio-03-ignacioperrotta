using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace lab3
{
    public class Producto
    {
        protected string nombre;
        protected int precio;
        protected string marca;
        protected int stock;
        
        public Producto(string nombre, int precio, string marca, int stock)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.marca = marca;
            this.stock = stock;
        }

       
        public string informacion()
        {
            return "nombre: " + nombre + ", precio: " + precio + ", marca: " + marca + ", stock: " + stock;
        }
      



        
    }
}