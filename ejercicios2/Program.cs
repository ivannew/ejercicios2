using ejercicios2.metodos;

namespace ejercicios2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EJERCICIO 1
            /* ejercicios ejercicios1 = new ejercicios();
             int[] resultado = ejercicios1.SumaDeArreglos();
             Console.WriteLine("Resultado de la suma:");
             ejercicios1.ImprimirArreglo(resultado);*/

            // EJERICIO 2
            /* ejercicios ejercicios1 = new ejercicios();
             Console.WriteLine("Ingrese el tamaño del arreglo:");
             int tamañoArreglo = int.Parse(Console.ReadLine());

             int[] arreglo = new int[tamañoArreglo];

             for (int i = 0; i < tamañoArreglo; i++)
             {
                 Console.Write($"Ingrese el valor {i + 1}: ");
                 arreglo[i] = int.Parse(Console.ReadLine());
             }

             Console.WriteLine("Ingrese el elemento a buscar:");
             int elementoBuscado = int.Parse(Console.ReadLine());

             int[] posicionesCoincidencia = ejercicios1.BuscarElemento(arreglo, elementoBuscado);

             Console.WriteLine("Posiciones de coincidencia:");
             foreach (int posicion in posicionesCoincidencia)
             {
                 Console.WriteLine($"Posición: {posicion}");
             } */
            //EJERCICIO 4

            /* ejercicios ejercicios1 = new ejercicios();

             Console.WriteLine("Ingrese el tamaño del arreglo:");
             int tamañoArreglo = int.Parse(Console.ReadLine());

             if (tamañoArreglo <= 0)
             {
                 Console.WriteLine("El tamaño del arreglo debe ser mayor que cero.");
                 return;
             }

             int[] arreglo = ejercicios1.CrearArreglo(tamañoArreglo);

             Console.WriteLine("\nContenido del arreglo:");

             foreach (int valor in arreglo)
             {
                 Console.Write(valor + " ");
             }

             Console.WriteLine();
         }
            */
            //EJERCICIO 5
            /* ejercicios ejercicios1 = new ejercicios();
             Console.Write("Ingrese la cantidad de notas: ");
             int N = int.Parse(Console.ReadLine());

             if (N <= 0)
             {
                 Console.WriteLine("La cantidad de notas debe ser mayor que cero.");
                 return;
             }

             int[] notas = new int[N];

             // Llenar el arreglo con las notas ingresadas por el usuario.
             for (int i = 0; i < N; i++)
             {
                 Console.Write($"Ingrese la nota {i + 1}: ");
                 notas[i] = int.Parse(Console.ReadLine());
             }

             int aprobadas, desaprobadas;
             double promedioAprobadas, promedioDesaprobadas;

             ejercicios1.CalcularEstadisticasNotas(notas, out aprobadas, out desaprobadas, out promedioAprobadas, out promedioDesaprobadas);

             ejercicios1.MostrarResumenNotas(aprobadas, desaprobadas, promedioAprobadas, promedioDesaprobadas);
            */

            //EJERCICIOS 3 
            /*ejercicios ejercicios1 = new ejercicios();
            Console.Write("Ingrese la cantidad de alumnos para Álgebra: ");
            int cantidadAlumnosAlgebra = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la cantidad de alumnos para Análisis: ");
            int cantidadAlumnosAnalisis = int.Parse(Console.ReadLine());

            int[] algebra = new int[cantidadAlumnosAlgebra];
            int[] analisis = new int[cantidadAlumnosAnalisis];

            // Ingresar IDs de alumnos para Álgebra.
            IngresarAlumnos(algebra, "Álgebra");

            // Ingresar IDs de alumnos para Análisis.
            IngresarAlumnos(analisis, "Análisis");

            // Encontrar y mostrar a los alumnos inscritos en ambas asignaturas.
            int[] alumnosEnAmbasAsignaturas = ejercicios1.EncontrarAlumnosEnAmbasAsignaturas(algebra, analisis);

            Console.WriteLine("\nAlumnos inscritos en ambas asignaturas:");
            foreach (int alumno in alumnosEnAmbasAsignaturas)
            {
                Console.WriteLine($"ID: {alumno}");
            }

            Console.WriteLine($"Número de alumnos que se repiten: {alumnosEnAmbasAsignaturas.Length}");
        }

        static void IngresarAlumnos(int[] arreglo, string asignatura)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write($"Ingrese el ID del alumno {i + 1} para {asignatura}: ");
                arreglo[i] = int.Parse(Console.ReadLine());
            }
        }*/
        }

    }
}