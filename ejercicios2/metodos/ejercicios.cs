using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios2.metodos
{
    internal class ejercicios
    {
        public int[] SumaDeArreglos()
        {
            Console.WriteLine("Escribe el tamaño del arreglo");
            int tamañoArreglos = Convert.ToInt32(Console.ReadLine());

            int[] arreglo1 = new int[tamañoArreglos];
            int[] arreglo2 = new int[tamañoArreglos];
            int[] resultado = new int[tamañoArreglos];

            Console.WriteLine("Número para el primer arreglo");
            for (int i = 0; i < tamañoArreglos; i++)
            {
                Console.WriteLine($"Valor {i + 1}:");
                arreglo1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Ahora escribe el segundo arreglo");
            for (int i = 0; i < tamañoArreglos; i++)
            {
                Console.WriteLine($"Valor {i + 1}:");
                arreglo2[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < tamañoArreglos; i++)
            {
                resultado[i] = arreglo1[i] + arreglo2[i];
            }

       
            return resultado;
        }
        public void ImprimirArreglo(int[] arreglo)
        {
            foreach (int valor in arreglo)
            {
                Console.Write(valor + " ");
            }
            Console.WriteLine();
        }

        public int[] BuscarElemento(int[] arreglo, int elementoBuscado)
        {
            int contadorCoincidencia = 0;
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] == elementoBuscado)
                {
                    contadorCoincidencia++;
                }
            }

            int[] posicionesCoincidencia = new int[contadorCoincidencia];
            contadorCoincidencia = 0;

            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] == elementoBuscado)
                {
                    posicionesCoincidencia[contadorCoincidencia] = i;
                    contadorCoincidencia++;
                }
            }

            return posicionesCoincidencia;
        }
        private List<int> alumnos = new List<int>();

        public void IngresarAlumnos()
        {
            Console.WriteLine("Ingrese los IDs de los alumnos para Álgebra (separados por espacios):");
            string[] input = Console.ReadLine().Split();

            foreach (string id in input)
            {
                int alumnoID = int.Parse(id);
                if (!alumnos.Contains(alumnoID))
                {
                    alumnos.Add(alumnoID);
                }
                else
                {
                    Console.WriteLine($"El alumno con ID {alumnoID} ya está inscrito en Álgebra.");
                }
            }
        }

        public IEnumerable<int> ObtenerAlumnos()
        {
            return alumnos;
        }
        // NO ENTENDIDO POR COMPLETO
        public  int[] CrearArreglo(int tamaño)
        {
            int[] arreglo = new int[tamaño];
            for (int i = 0; i < tamaño; i++)
            {
                int valor;
                do
                {
                    Console.Write($"Ingrese el valor {i + 1}: ");
                    valor = int.Parse(Console.ReadLine());

                    if (Array.Exists(arreglo, element => element == valor))
                    {
                        Console.WriteLine("El valor ya existe en el arreglo. Intente nuevamente.");
                    }
                } while (Array.Exists(arreglo, element => element == valor));

                arreglo[i] = valor;
            }
            return arreglo;
        }
        // sacado con ayuda
        public void CalcularEstadisticasNotas(int[] notas, out int aprobadas, out int desaprobadas, out double promedioAprobadas, out double promedioDesaprobadas)
        {
            aprobadas = 0;
            desaprobadas = 0;
            int sumaAprobadas = 0;
            int sumaDesaprobadas = 0;

            foreach (int nota in notas)
            {
                if (nota >= 0 && nota <= 5)
                {
                    desaprobadas++;
                    sumaDesaprobadas += nota;
                }
                else if (nota >= 6 && nota <= 15)
                {
                    aprobadas++;
                    sumaAprobadas += nota;
                }
                else if (nota >= 16 && nota <= 20)
                {
                    aprobadas++;
                    sumaAprobadas += nota;
                }
            }

            promedioAprobadas = aprobadas > 0 ? (double)sumaAprobadas / aprobadas : 0;
            promedioDesaprobadas = desaprobadas > 0 ? (double)sumaDesaprobadas / desaprobadas : 0;
        }

        public void MostrarResumenNotas(int aprobadas, int desaprobadas, double promedioAprobadas, double promedioDesaprobadas)
        {
            Console.WriteLine("\nResumen de notas:");
            Console.WriteLine($"Cantidad de notas aprobadas: {aprobadas}");
            Console.WriteLine($"Cantidad de notas desaprobadas: {desaprobadas}");
            Console.WriteLine($"Promedio de notas aprobadas: {promedioAprobadas:F2}");
            Console.WriteLine($"Promedio de notas desaprobadas: {promedioDesaprobadas:F2}");
        }
       public int[] EncontrarAlumnosEnAmbasAsignaturas(int[] arreglo1, int[] arreglo2)
        {
            int[] alumnosEnAmbasAsignaturas = new int[Math.Min(arreglo1.Length, arreglo2.Length)];
            int contador = 0;

            foreach (int alumno1 in arreglo1)
            {
                foreach (int alumno2 in arreglo2)
                {
                    if (alumno1 == alumno2)
                    {
                        alumnosEnAmbasAsignaturas[contador] = alumno1;
                        contador++;
                        break; // Para evitar agregar el mismo alumno varias veces.
                    }
                }
            }

            Array.Resize(ref alumnosEnAmbasAsignaturas, contador);

            return alumnosEnAmbasAsignaturas;
        }

        public void IngresarAlumnos(int[] arreglo, string asignatura)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write($"Ingrese el ID del alumno {i + 1} para {asignatura}: ");
                arreglo[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
