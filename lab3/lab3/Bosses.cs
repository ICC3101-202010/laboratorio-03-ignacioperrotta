using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace lab3
{
    public class Bosses : Empleados
    {


        public Bosses(string horario_de_trabajo, string sueldo, string rut, string nombre, string apellido, string fecha_nacimiento, string nacionalidad, string genero) : base(horario_de_trabajo, sueldo, rut, nombre, apellido, fecha_nacimiento, nacionalidad, genero)
        {
            this.Puesto_De_Trabajo = "jefe";
            this.Sueldo = sueldo;
            this.Horario_De_Trabajo = horario_de_trabajo;
            this.Rut = rut;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Fecha_Nacimiento = fecha_nacimiento;
            this.Nacionalidad = nacionalidad;
            this.Genero = genero;
        }
    }
}


