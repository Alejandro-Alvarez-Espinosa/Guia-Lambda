using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_Lambda
{
    public class Estudiante
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public double Nota { get; set; }

        public Estudiante(string nombre, int edad, double nota) 
        { 
            this.Nombre = nombre;
            this.Edad = edad;
            this.Nota = nota;
        }
    }
}
