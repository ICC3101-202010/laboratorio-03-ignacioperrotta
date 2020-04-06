using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace lab3
{
    public class Usuario
    {
        private List<Supervisors> supervisors = new List<Supervisors>();
        private List<Assistants> assistants = new List<Assistants>();
        private List<Bosses> bosses = new List<Bosses>();

        public bool CrearEmpleado(string rut, string nombre, string apellido, string fecha_nacimiento, string nacionalidad, string genero, string horario_de_trabajo, string sueldo, string puesto_de_trabajo)
        {
            if (puesto_de_trabajo == "jefe")
            {
                Bosses boss = new Bosses(rut, nombre, apellido, fecha_nacimiento, nacionalidad, genero, horario_de_trabajo, sueldo);
                if (bosses.Contains(boss))
                {
                    Console.WriteLine("No se puede crear este trabajador, debido a que ya existe");
                    return false;
                }
               
              
                bosses.Add(boss);
                return true;
            }
            else if (puesto_de_trabajo == "auxiliar")
            {
                Assistants assistant = new Assistants(rut, nombre, apellido, fecha_nacimiento, nacionalidad, genero, horario_de_trabajo, sueldo);
                if (assistants.Contains(assistant))
                {
                    Console.WriteLine("No se puede crear este trabajador, debido a que ya existe");
                    return false;
                }


                assistants.Add(assistant);
                return true;
            }
            if (puesto_de_trabajo == "supervisor")
            {
                Supervisors supervisor = new Supervisors(rut, nombre, apellido, fecha_nacimiento, nacionalidad, genero, horario_de_trabajo, sueldo);
                if (supervisors.Contains(supervisor))
                {
                    Console.WriteLine("No se puede crear este trabajador, debido a que ya existe");
                    return false;
                }


                supervisors.Add(supervisor);
                return true;
            }

            else
            {
                Console.WriteLine("el valor que usted ingresó no es válido");
                return false;
            }



        }
        List<Clientes> customers = new List<Clientes>();
        List<Producto> products = new List<Producto>();
        
        public void see_products()
        {
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine(products[i].informacion());
            }
        }
        public bool CrearProducto(string nombre, int precio, string marca, int stock)
        {
            Producto producto = new Producto(nombre, precio, marca, stock);
            if (products.Contains(producto))
            {
                return false;
            }
            else
            {
                products.Add(producto);
                return true;
            }


        }


    }
}
