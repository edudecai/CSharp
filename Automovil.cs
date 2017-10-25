using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialCSharp
{
    class Automovil
    {
        //atributos
        private string color;
        private int ruedas;
        private int puertas;

        //constructor
        public Automovil(string color, int ruedas, int puertas)
        {
            this.color = color;
            this.ruedas = ruedas;
            this.puertas = puertas;

        }
        //constructor default
        public Automovil()
        {
            this.color = "Azul";
            this.ruedas = 1;
            this.puertas = 1;
        }
        //GET
        public string ObtenerColor()
        {
            return this.color;
        }
        public int ObtenerRuedas()
        {
            return this.ruedas;
        }
        public int ObtenerPuertas()
        {
            return this.puertas;
        }
    }
}
