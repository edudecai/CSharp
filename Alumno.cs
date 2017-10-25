using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialCSharp
{
    class Alumno
    {
        //atributos
        private int Edad;
        private int Peso;
        private int Altura;
        private string Nombre;

        //metodo constructor
        public Alumno(int Edad, int Peso, int Altura, string Nombre)
        {
            this.Edad = Edad;
            this.Peso = Peso;
            this.Altura = Altura;
            this.Nombre = Nombre;
        }

        //metodos GET : obtener info de los atributos de la clase

        public int ObtenerEdad()
        {
            return this.Edad;
        }
        public int ObtenerPeso()
        {
            return this.Peso;
        }
        public int ObtenerAltura()
        {
            return this.Altura;
        }
        public string ObtenerNombre()
        {
            return this.Nombre;
        }

        // SET : cambiar atributos de la clase

        public void AsignarEdad(int Edad)
        {
            this.Edad = Edad;
        }
        public void AsignarPeso(int Peso)
        {
            this.Peso = Peso;
        }
        public void AsignarAltura(int Altura)
        {
            this.Altura = Altura;
        }
        public void AsignarNombre(string Nombre)
        {
            this.Nombre = Nombre;
        }
    }
}
