using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppClassHerencia2
{
    class Alumno : Persona
    {
        private double matricula;

        public double Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
        private string carrera;

        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }
        public Alumno() : base()
        {
            matricula = 0;
            carrera = "";
        }
        public Alumno(string nombre, string fechaNacimiento, double matricula, string carrera) : base(nombre, fechaNacimiento)
        {
            this.matricula = matricula;
            this.carrera = carrera;
        }
        public override string ToString()
        {
            return base.ToString() + "  Matricula:" + matricula + "  Carrera:" + carrera;

        }
    }
}
