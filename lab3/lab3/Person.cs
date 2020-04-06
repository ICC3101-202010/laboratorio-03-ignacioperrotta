using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace lab3
{
    public class Person
    {
        private string rut;
        private string nombre;
        private string apellido;
        private string fecha_nacimiento;
        private string nacionalidad;
        private string genero;
        public Person(string rut, string nombre, string apellido, string fecha_nacimiento, string nacionalidad, string genero)
        {
            this.Rut = rut;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Fecha_Nacimiento = fecha_nacimiento;
            this.Nacionalidad = nacionalidad;
            this.Genero = genero;
        }
        public string Rut
        {
            get
            {
                return rut;
            }
            set
            {
                rut = value;
            }
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                apellido = value;
            }
        }
        public string Fecha_Nacimiento
        {
            get
            {
                return fecha_nacimiento;
            }
            set
            {
                fecha_nacimiento = value;
            }
        }
        public string Nacionalidad
        {
            get
            {
                return nacionalidad;
            }
            set
            {
                nacionalidad = value;
            }
        }
        public string Genero
        {
            get
            {
                return genero;
            }
            set
            {
                genero = value;
            }
        }

      
    }
}