using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace lab3
{
    public class Clientes : Person
    {
        public Clientes(string rut, string nombre, string apellido, string fecha_nacimiento, string nacionalidad, string genero) : base(rut, nombre, apellido, fecha_nacimiento, nacionalidad, genero)
        {

            this.Rut = rut;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Fecha_Nacimiento = fecha_nacimiento;
            this.Nacionalidad = nacionalidad;
            this.Genero = genero;


        }

    }
}
