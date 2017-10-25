using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TutorialCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CMD_Mostrar_Click(object sender, EventArgs e)
        {

            /* instanciar objeto alumno
            Alumno Alumno_Gabriel = new Alumno(38, 89, 173, "Gabriel");
            MessageBox.Show("DATOS DEL ALUMNO"
                            + "\n   Edad       : " + Alumno_Gabriel.ObtenerEdad()
                            + "\n   Peso       : " + Alumno_Gabriel.ObtenerPeso()
                            + "\n   Altura     : " + Alumno_Gabriel.ObtenerAltura()
                            + "\n   Nombre     : " + Alumno_Gabriel.ObtenerNombre()
                            );
            Alumno_Gabriel.AsignarEdad(20);
            Alumno_Gabriel.AsignarNombre("Gabriela");
            MessageBox.Show("DATOS DEL ALUMNO"
                            + "\n   Edad       : " + Alumno_Gabriel.ObtenerEdad()
                            + "\n   Peso       : " + Alumno_Gabriel.ObtenerPeso()
                            + "\n   Altura     : " + Alumno_Gabriel.ObtenerAltura()
                            + "\n   Nombre     : " + Alumno_Gabriel.ObtenerNombre()
                            ); */
            Automovil auto = new Automovil("Verde", 4, 4);
            MessageBox.Show("DATOS DEL COCHE CON PARAM"
                          + "\n   Color       : " + auto.ObtenerColor()
                          + "\n   Ruedas      : " + auto.ObtenerRuedas()
                          + "\n   Puertas     : " + auto.ObtenerPuertas()
                          );
            Automovil auto2 = new Automovil();
            MessageBox.Show("DATOS DEL COCHE SIN PARAM"
                          + "\n   Color       : " + auto2.ObtenerColor()
                          + "\n   Ruedas      : " + auto2.ObtenerRuedas()
                          + "\n   Puertas     : " + auto2.ObtenerPuertas()
                          );
        }
    }
}
