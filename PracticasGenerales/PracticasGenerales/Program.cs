using System;

namespace PracticasGenerales
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[] edades;
             edades = new int[5];
             edades[0] = 15;
             edades[1] = 27;
             edades[2] = 30;
             edades[3] = 45;
             edades[4] = 60;
             */
            int[] edades = { 16, 25, 19, 80 };
            //int[] edades1 = new int[5] { 16, 25, 19, 80, 20 };
            Console.WriteLine(edades[4]);

            //array implicito
            var datos = new[] { "Israel", "Jimenez", "Ecuador" };
            var datosn = new[] { 15, 20, 18 };

            //array de objetos
            Empleados Ana = new Empleados("Ana", 27);

            Empleados[] arrayEmpleados = new Empleados[2];
            arrayEmpleados[0] = new Empleados("Israel", 32);

            arrayEmpleados[1] = Ana;

            //array de tipo o clases anonimas
            var personas = new[]
            {
                new{Nombre="Ernesto", Edad=19},
                new{Nombre="Maria", Edad=49},
                new {Nombre="Ana", Edad=25}
            };

        }
    }

    class Empleados
    {
        public Empleados(String nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
        String nombre;
        int edad;
    }
}
