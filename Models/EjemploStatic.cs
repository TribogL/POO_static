using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_static.Models
{
    public class EjemploStatic
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public EjemploStatic()
        {
            this.Nombre = "Julian";
            this.Apellido = "Forero";
        }

        public void Saludar()
        {
            Console.WriteLine($"Hola a todos soy: {Nombre}{Apellido}");
        }
    }
}