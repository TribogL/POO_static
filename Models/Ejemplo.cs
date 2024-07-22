using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_static.Models;

public class Ejemplo
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public Ejemplo(string nombre, string apellido)
    {
        this.Nombre = nombre;
        this.Apellido = apellido;
    }

    public void Saludar()
    {
        Console.WriteLine($"Hola a todos soy: {Nombre}{Apellido}");
    }


}
