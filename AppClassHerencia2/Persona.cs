using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppClassHerencia2
{
    class Persona
    {
        protected string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        protected string fechaNacimiento;

        protected string FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }
        public Persona()
        {
            nombre = "";
            fechaNacimiento = "";
        }
        public Persona(string nombre, string fechaNacimiento)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
        }
        public override string ToString()
        {
            return "   Nombre:" +  nombre  + "  Fecha de Nacimiento:" +  fechaNacimiento ;
        }
    }
}
