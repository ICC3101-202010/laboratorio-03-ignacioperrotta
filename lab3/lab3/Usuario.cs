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
        public List<Cajeros> cajeros = new List<Cajeros>();
        Cajeros c1 = new Cajeros("20163936 - 4", "Ignacio", "Pérez", "01 / 09 / 92", "chilena", "masculino", "11:00-20:00", "400.000");
        Cajeros c2 = new Cajeros("8164985 - 9", "Diego", "Torres", "12 / 03 / 70", "chilena", "masculino", "11:00-20:00", "400.000");
        Cajeros c3 = new Cajeros("19529563 - 6", "Adriana", "Lima", "09 / 12 / 95", "brasileña", "femenino", "11:00-20:00", "400.000");
        Cajeros c4 = new Cajeros("15745398 - k", "Tony", "Stark", "01 / 01 / 78", "Haitiana", "masculino", "11:00-20:00", "400.000");
        Producto p1 = new Producto("cuaderno", 2000, "Rhein", 3);
        Producto p2 = new Producto("Agua 1 lt.", 1200, "Cachantún", 6);
        public void AgregarCajeros()
        {
            products.Add(p1);
            products.Add(p2);
            cajeros.Add(c1);
            cajeros.Add(c2);
            cajeros.Add(c3);
            cajeros.Add(c4);
        }
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
            else if (puesto_de_trabajo == "cajero")
            {
                Cajeros cajero = new Cajeros(rut, nombre, apellido, fecha_nacimiento, nacionalidad, genero, horario_de_trabajo, sueldo);
                if (cajeros.Contains(cajero))
                {
                    Console.WriteLine("No se puede crear este trabajador, debido a que ya existe");
                    return false;
                }


                cajeros.Add(cajero);
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
                Console.WriteLine(i + ")" + products[i].informacion());
            }
            if (products.Count == 0)
            {
                Console.WriteLine("No hay productos disponibles, por favor cree alguno");
            }
        }
        List<Producto> Carro = new List<Producto>();
        public void VerCarro()
        {
            for (int i = 0; i < Carro.Count; i++)
            {
                Console.WriteLine(Carro[i]);
            }
        }
        public List<Producto> Agregar_al_carro()
        {
            Console.WriteLine("¿Qué producto desea agregar?");
            see_products();
            int producto_ingresado;
            producto_ingresado = Int32.Parse(Console.ReadLine());
            Producto ProductoIngresado = products[producto_ingresado];
            Console.WriteLine("¿Cuantos Quiere?");
            int cantidad_ingresada;
            cantidad_ingresada = Int32.Parse(Console.ReadLine());
            int resta_stock;
            resta_stock = ProductoIngresado.stock - cantidad_ingresada;
            if (resta_stock >= 0)
            {
                for (int i = 0; i < cantidad_ingresada;i++)
                {
                    Carro.Add(ProductoIngresado);
                    ProductoIngresado.stock = resta_stock;
                    
                }
                Console.WriteLine("Producto ha sido agregado");

            }
            else
            {
                Console.WriteLine("No hay stock disponible");
                ProductoIngresado.stock = resta_stock + cantidad_ingresada;

            }
            while (true)
            {
                Console.WriteLine("¿Desea agregar otro producto al carro?");
                Console.WriteLine("si o no");
                string si_o_no = Console.ReadLine();
                if (si_o_no == "si")
                {
                    see_products();
                    int producto_ingresado2;
                    producto_ingresado2 = Int32.Parse(Console.ReadLine());
                    Producto ProductoIngresado2 = products[producto_ingresado2];
                    Console.WriteLine("¿Cuantos Quiere?");
                    int cantidad_ingresada2;
                    cantidad_ingresada2 = Int32.Parse(Console.ReadLine());
                    int resta_stock2;
                    resta_stock2 = ProductoIngresado2.stock - cantidad_ingresada2;
                    if (resta_stock2 >= 0)
                    {
                        for (int i = 0; i < cantidad_ingresada2; i++)
                        {
                            Carro.Add(ProductoIngresado2);
                            ProductoIngresado2.stock = resta_stock2;
                            
                        }
                        Console.WriteLine("Producto ha sido agregado");

                    }
                    else
                    {
                        Console.WriteLine("No hay stock disponible");
                        ProductoIngresado2.stock = resta_stock2 + cantidad_ingresada2;
                    }

                }
                else if (si_o_no == "no")
                {
                    Console.WriteLine("Carro de compras:");
                    for (int i = 0; i < Carro.Count; i++)
                    {
                        Console.WriteLine(Carro[i].informacion());
                    }
                    return Carro;
                }
                else
                {
                    Console.WriteLine("Opcion inválida, por favor selecciona si o no");
                }

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
        public void Ver_Trabajadores()
        {
            Console.WriteLine("Jefes:");
            for (int i = 0; i < bosses.Count; i++)
            {
                Console.WriteLine(bosses[i].Ver_Empleado());
            }

            Console.WriteLine("Supervisores:");
            for (int i = 0; i < supervisors.Count; i++)
            {
                Console.WriteLine(supervisors[i].Ver_Empleado());
            }

            Console.WriteLine("Auxiliares:");
            for (int i = 0; i < assistants.Count; i++)
            {
                Console.WriteLine(assistants[i].Ver_Empleado());
            }
            Console.WriteLine("Cajeros:");
            for (int i = 0; i < cajeros.Count; i++)
            {
                Console.WriteLine(cajeros[i].Ver_Empleado());
            }
        }
        public List<Clientes> clientes = new List<Clientes>();
        public void Ver_Clientes()
        {
            Console.WriteLine("Clientes:");
            for (int i = 0; i < clientes.Count; i++)
            {
                Console.WriteLine(i + ")" + clientes[i].Info_Cliente());
            }
        }

        public bool CrearCliente(string rut, string nombre, string apellido, string fecha_nacimiento, string nacionalidad, string genero)
        {
            Clientes nuevo_cliente = new Clientes(rut, nombre, apellido, fecha_nacimiento, nacionalidad, genero);
            if (clientes.Contains(nuevo_cliente))
            {
                Console.WriteLine("No se puede crear este cliente, debido a que ya existe");
                return false;
            }


            clientes.Add(nuevo_cliente);
            return true;
        }
        public void Ver_Cajeros()
        {
            Console.WriteLine("Cajeros:");
            for (int i = 0; i < cajeros.Count; i++)
            {
                Console.WriteLine(i + ")" + cajeros[i].Ver_Empleado());
            }
        }

    }
}
