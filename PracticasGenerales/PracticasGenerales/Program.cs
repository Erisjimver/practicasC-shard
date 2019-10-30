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
            Console.WriteLine(edades[2]);

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
            for (int i = 0; i < personas.Length; i++)
            {
                Console.WriteLine($"Las personas son: {personas[i]}");
            }
            int[] numeros = new int[4];
            numeros[0] = 7;
            numeros[1] = 9;
            numeros[2] = 15;
            numeros[3] = 3;
            ProcesarDatos(numeros);

            //crear un array por consola
            //leerDatos();
            int[] arrayElementos=leerDatos();
            foreach (int i in arrayElementos) Console.WriteLine(i);
            

            
        }
        static void ProcesarDatos(int[] datos)
        {
            foreach (int i in datos)
            {
                Console.WriteLine(i);
            }
        }

        static int[] leerDatos()
        {
            Console.WriteLine("¿Cuantos elementos contendra el arreglo? ");
            string respuesta = Console.ReadLine();
            int numElementos = int.Parse(respuesta);
            int[] datos = new int[numElementos];

            for (int i = 0; i < numElementos; i++)
            {
                Console.WriteLine($"Introduce el dato para la posicion{i} ");
                respuesta = Console.ReadLine();
                int datosElementos = int.Parse(respuesta);
                datos[i] = datosElementos;

            }
            return datos;
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
