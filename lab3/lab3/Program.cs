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
            Console.WriteLine("(2) Ver empleados");
            Console.WriteLine("(3) crear cliente");
            Console.WriteLine("(4) Crear producto");
            Console.WriteLine("(5) Ver productos");
            Console.WriteLine("(6) Realizar compras");
            Console.WriteLine("(7) Salir del supermercado");
            string input_usuario;
            input_usuario = Console.ReadLine();
            Usuario usuario = new Usuario();
            usuario.AgregarCajeros();
            
            while (input_usuario == "1" || input_usuario == "2" || input_usuario == "3" || input_usuario == "4" || input_usuario == "5" || input_usuario == "6" || input_usuario == "6")
            {
                if (input_usuario == "1")
                {

                    Console.WriteLine("Rut del empleado  (Ej: 12345678-9)");
                    string n_rut;
                    n_rut = Console.ReadLine();
                    Console.WriteLine("Genero del empleado (Masculino/Femenino/Otro)");
                    string n_genero;
                    n_genero = Console.ReadLine();
                    Console.WriteLine("Nombre del empleado");
                    string n_nombre;
                    n_nombre = Console.ReadLine();
                    Console.WriteLine("Apellido del empleado");
                    string n_apellido;
                    n_apellido = Console.ReadLine();
                    Console.WriteLine("Fecha de nacimiento del empleado (dd/mm/aa)");
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
                    usuario.Ver_Trabajadores();
                }
                else if (input_usuario == "3")
                {
                    Console.WriteLine("Rut del cliente (Ej: 12345678-9)");
                    string n_rut;
                    n_rut = Console.ReadLine();
                    Console.WriteLine("Genero del cliente (Masculino/Femenino/Otro)");
                    string n_genero;
                    n_genero = Console.ReadLine();
                    Console.WriteLine("Nombre del cliente");
                    string n_nombre;
                    n_nombre = Console.ReadLine();
                    Console.WriteLine("Apellido del cliente");
                    string n_apellido;
                    n_apellido = Console.ReadLine();
                    Console.WriteLine("Fecha de nacimiento del cliente (dd/mm/aa)");
                    string n_fecha_de_nacimiento;
                    n_fecha_de_nacimiento = Console.ReadLine();
                    Console.WriteLine("Nacionalidad del cliente");
                    string n_nacionalidad;
                    n_nacionalidad = Console.ReadLine();
                    usuario.CrearCliente(n_rut, n_nombre, n_apellido, n_fecha_de_nacimiento, n_nacionalidad, n_genero);
                    
                }
                else if (input_usuario == "4")
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
                else if (input_usuario == "5")
                {
                    usuario.see_products();
                }
                else if (input_usuario == "6")
                {
                    Console.WriteLine("¿Está usted registrado como cliente?");
                    Console.WriteLine("a) si , b) no;");
                    string input_registrado;
                    input_registrado = Console.ReadLine();
                    if (input_registrado == "a")
                    {
                        Console.WriteLine("¿Qué cliente desea ocupar?");
                        usuario.Ver_Clientes();
                        int cliente_ingresado1;
                        cliente_ingresado1 = Int32.Parse(Console.ReadLine());
                        Clientes cliente1 = usuario.clientes[cliente_ingresado1];
                        List<Producto> Carro1 = usuario.Agregar_al_carro();
                        Console.WriteLine("¿Qué cajero desea ocupar?");
                        usuario.Ver_Cajeros();
                        int cajero_ingresado1;
                        cajero_ingresado1 = Int32.Parse(Console.ReadLine());
                        Cajeros cajero1 = usuario.cajeros[cajero_ingresado1];
                        Console.WriteLine("Ingrese la fecha (dd/mm/aa)");
                        string n_fecha1;
                        n_fecha1 = Console.ReadLine();
                        Console.WriteLine("Ingrese la hora (hh:mm)");
                        string n_hora1;
                        n_hora1 = Console.ReadLine();
                        Console.WriteLine("REGISTRO DE COMPRA");
                        Console.WriteLine("Fecha: " + n_fecha1);
                        Console.WriteLine("Hora: " + n_hora1);
                        Console.WriteLine("Cliente:");
                        Console.WriteLine(cliente1.Info_Cliente());
                        Console.WriteLine("Cajero:");
                        Console.WriteLine(cajero1.Ver_Empleado());
                        Console.WriteLine("Los productos comprados fueron:");
                        int cuenta1 = 0;
                        for (int i = 0; i < Carro1.Count; i++)
                        {
                            Console.WriteLine(Carro1[i].informacion_registro());
                            cuenta1 += Carro1[i].precio;
                        }
                        Console.WriteLine("Total a pagar ");
                        Console.WriteLine("$" + cuenta1);
                        Console.WriteLine("FIN DEL REGISTRO");
                    }
                    else if (input_registrado == "b")
                    {
                        Console.WriteLine("Rut del cliente (Ej: 12345678-9)");
                        string n_rut;
                        n_rut = Console.ReadLine();
                        Console.WriteLine("Genero del cliente (Masculino/Femenino/Otro)");
                        string n_genero;
                        n_genero = Console.ReadLine();
                        Console.WriteLine("Nombre del cliente");
                        string n_nombre;
                        n_nombre = Console.ReadLine();
                        Console.WriteLine("Apellido del cliente");
                        string n_apellido;
                        n_apellido = Console.ReadLine();
                        Console.WriteLine("Fecha de nacimiento del cliente (dd/mm/aa)");
                        string n_fecha_de_nacimiento;
                        n_fecha_de_nacimiento = Console.ReadLine();
                        Console.WriteLine("Nacionalidad del cliente");
                        string n_nacionalidad;
                        n_nacionalidad = Console.ReadLine();
                        usuario.CrearCliente(n_rut, n_nombre, n_apellido, n_fecha_de_nacimiento, n_nacionalidad, n_genero);
                        Console.WriteLine("Cliente ha sido creado");

                        Console.WriteLine("¿Qué cliente desea ocupar?");
                        usuario.Ver_Clientes();
                        int cliente_ingresado;
                        cliente_ingresado = Int32.Parse(Console.ReadLine());
                        Clientes cliente = usuario.clientes[cliente_ingresado];
                        List<Producto> Carro = usuario.Agregar_al_carro();
                        Console.WriteLine("¿Qué cajero desea ocupar?");
                        usuario.Ver_Cajeros();
                        int cajero_ingresado;
                        cajero_ingresado = Int32.Parse(Console.ReadLine());
                        Cajeros cajero = usuario.cajeros[cajero_ingresado];
                        Console.WriteLine("Ingrese la fecha (dd/mm/aa)");
                        string n_fecha;
                        n_fecha = Console.ReadLine();
                        Console.WriteLine("Ingrese la hora (hh:mm)");
                        string n_hora;
                        n_hora = Console.ReadLine();
                        Console.WriteLine("REGISTRO DE COMPRA");
                        Console.WriteLine("Fecha: " + n_fecha);
                        Console.WriteLine("Hora: " + n_hora);
                        Console.WriteLine("Cliente:");
                        Console.WriteLine(cliente.Info_Cliente());
                        Console.WriteLine("Cajero:");
                        Console.WriteLine(cajero.Ver_Empleado());
                        Console.WriteLine("Los productos comprados fueron:");
                        int cuenta = 0;
                        for (int i = 0; i < Carro.Count; i++)
                        {
                            Console.WriteLine(Carro[i].informacion_registro());
                            cuenta += Carro[i].precio;
                        }
                        Console.WriteLine("Total a pagar ");
                        Console.WriteLine("$" + cuenta);
                        Console.WriteLine("FIN DEL REGISTRO");
                    }
                    else
                    {
                        Console.WriteLine("La opción ingresada no es válida");
                    }


                }
                else if (input_usuario == "7")
                {
                    break;
                }

                else
                {
                    Console.WriteLine("El criterio ingresado no es válido");
                }
                Console.WriteLine("Welcome to the supermarket");
                Console.WriteLine("Seleecione que opción desea realizar");
                Console.WriteLine("(1) Crear empleado");
                Console.WriteLine("(2) Ver empleados");
                Console.WriteLine("(3) crear cliente");
                Console.WriteLine("(4) Crear producto");
                Console.WriteLine("(5) Ver productos");
                Console.WriteLine("(6) Realizar compras");
                Console.WriteLine("(7) Salir del supermercado");
                input_usuario = Console.ReadLine();
                
            }

        }
    }
}
