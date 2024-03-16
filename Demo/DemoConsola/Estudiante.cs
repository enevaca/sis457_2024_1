using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsola
{
    public class Estudiante : Persona
    {
        public string carnetUniversitario { get; set; }

        public override void saludar()
        {
            Console.WriteLine($"Soy {nombres} {segundoApellido} y mi CU es {carnetUniversitario}");
        }
    }
}
