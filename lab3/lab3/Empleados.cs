using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace lab3
{
    public class Empleados : Person
    {

        private string puesto_de_trabajo;
        private string sueldo;
        private string horario_de_trabajo;
       

        public string Puesto_De_Trabajo
        {
            get
            {
                return puesto_de_trabajo;
            }
            set
            {
                puesto_de_trabajo = value;
            }
        }
        public string Sueldo
        {
            get
            {
                return sueldo;
            }
            set
            {
                sueldo = value;
            }
        }
        public string Horario_De_Trabajo
        {
            get
            {
                return horario_de_trabajo;
            }
            set
            {
                horario_de_trabajo = value;
            }
        }
        public Empleados(string horario_de_trabajo, string sueldo, string rut, string nombre, string apellido, string fecha_nacimiento, string nacionalidad, string genero) : base(rut, nombre, apellido, fecha_nacimiento, nacionalidad, genero)
        {

            this.Sueldo = sueldo;
            this.Horario_De_Trabajo = horario_de_trabajo;
            this.Rut = rut;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Fecha_Nacimiento = fecha_nacimiento;
            this.Nacionalidad = nacionalidad;
            this.Genero = genero;
        }
        public string Ver_Empleado()
        {
            return "Horario_de_trabajo: " + this.Horario_De_Trabajo + ",  Sueldo:" + this.Sueldo + ", Rut: " + this.Rut + ",  Nombre: " + this.Nombre + ",  Apellido: " + this.Apellido + ",  Fecha de nacimiento: " + this.Fecha_Nacimiento + ",  Nacionalidad: " + this.Nacionalidad + ",  Genero: " + this.Genero;
        }
        

    }
}