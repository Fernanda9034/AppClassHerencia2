using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppClassHerencia2
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a;
            a = new Alumno("Maria Fernanda Ortegon Posadas",  "01/11/03",  21050345,  "Informatica");
            Console.WriteLine(a.ToString());
            Console.ReadKey();

        }
    }
}
    

