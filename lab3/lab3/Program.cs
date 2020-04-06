using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the supermarket");
            Console.WriteLine("Seleecione que opción desea realizar");
            Console.WriteLine("(1) Crear empleado");
            Console.WriteLine("(2) Crear producto");
            Console.WriteLine("(3) Ver productos");
            Console.WriteLine("(4) Realizar compras");
            Console.WriteLine("(5) Salir del supermercado");
            string input_usuario;
            input_usuario = Console.ReadLine();
            Usuario usuario = new Usuario();
            while (input_usuario == "1" || input_usuario == "2" || input_usuario == "3" || input_usuario == "4" || input_usuario == "5")
            {
                if (input_usuario == "1")
                {

                    Console.WriteLine("Rut del empleado");
                    string n_rut;
                    n_rut = Console.ReadLine();
                    Console.WriteLine("Genero del empleado");
                    string n_genero;
                    n_genero = Console.ReadLine();
                    Console.WriteLine("Nombre del empleado");
                    string n_nombre;
                    n_nombre = Console.ReadLine();
                    Console.WriteLine("Apellido del empleado");
                    string n_apellido;
                    n_apellido = Console.ReadLine();
                    Console.WriteLine("Fecha de nacimiento del empleado");
                    string n_fecha_de_nacimiento;
                    n_fecha_de_nacimiento = Console.ReadLine();
                    Console.WriteLine("Nacionalidad del empleado");
                    string n_nacionalidad;
                    n_nacionalidad = Console.ReadLine();
                    Console.WriteLine("Puesto de trabajo del empleado (jefe, supervisor o auxiliar)");
                    string n_puesto_de_trabajo;
                    n_puesto_de_trabajo = Console.ReadLine();
                    Console.WriteLine("Sueldo del empleado");
                    string n_sueldo_del_empleado;
                    n_sueldo_del_empleado = Console.ReadLine();
                    Console.WriteLine("Horario de trabajo del empleado (hora ingreso-hora salida)");
                    string n_horario_de_trabajo;
                    n_horario_de_trabajo = Console.ReadLine();
                    usuario.CrearEmpleado(n_rut, n_nombre, n_apellido, n_fecha_de_nacimiento, n_nacionalidad, n_genero, n_horario_de_trabajo, n_sueldo_del_empleado, n_puesto_de_trabajo);

                }
                else if (input_usuario == "2")
                {
                    Console.WriteLine("Nombre del producto");
                    string n_nombre;
                    n_nombre = Console.ReadLine();
                    Console.WriteLine("Precio del producto");
                    int n_precio;
                    n_precio = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Marca del producto");
                    string n_marca;
                    n_marca = Console.ReadLine();
                    Console.WriteLine("Stock del producto");
                    int n_stock;
                    n_stock = Int32.Parse(Console.ReadLine());
                    usuario.CrearProducto(n_nombre, n_precio, n_marca, n_stock);

                }
                else if (input_usuario == "3")
                {
                    usuario.see_products();
                }
                else if (input_usuario == "5")
                {
                    break;
                }

                else
                {
                    Console.WriteLine("El criterio ingresado no es válido");
                }
                Console.WriteLine("Seleecione que opción desea realizar");
                Console.WriteLine("(1) Crear empleado");
                Console.WriteLine("(2) Crear producto");
                Console.WriteLine("(3) Ver productos");
                Console.WriteLine("(4) Realizar compras");
                Console.WriteLine("(5) Salir del programa");

                input_usuario = Console.ReadLine();

            }

        }
    }
}
