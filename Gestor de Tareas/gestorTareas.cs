using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Threading;

namespace GestionTareas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? entrada;
            int opcion = 0, listado = 1; ;
            Queue<string> tareas = new Queue<string>();
            do
            {
                Console.Clear();
                Console.WriteLine("**** GESTIÓN DE TAREAS ****");
                Console.WriteLine("1. Agregar Tarea");
                Console.WriteLine("2. Realizar Tarea");
                Console.WriteLine("3. Mostrar siguiente Tarea");
                Console.WriteLine("4. Mostrar cantidad de Tareas pendientes");
                Console.WriteLine("5. Mostrar todas las Tareas por realiar");
                Console.WriteLine("6. Salir del programa");
                Console.Write(">>> ");
                entrada = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(entrada) || !int.TryParse(entrada, out opcion))
                {
                    Console.WriteLine("ERORR. CAMPO VACÍO O DATOS NO ENTRADA NO PERMITIDA");
                    Console.WriteLine("Intente nuevamente...");
                    Console.WriteLine("Presione cualuquier tecla para continuar...");
                    Console.ReadKey();
                    continue;
                }


                switch (opcion)
                {
                    case 1:
                        AgregarTarea(tareas, ref listado);
                        break;

                    case 2:
                        RealizarTarea(tareas);
                        break;

                    case 3:
                        SiguienteTarea(tareas);
                        break;

                    case 4:
                        MostrarCantidad(tareas);
                        break;
                    case 5:
                        MostrarTareas(tareas);
                        break;
                    case 6:
                        CerrarPrograma();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("ERROR. INGRESA UNA OPCIÓN ENTRE 1-6");
                        Console.WriteLine("Intente nuevamente...");
                        Console.WriteLine("Presione cualquier tecla para continuar");
                        break;
                }

            } while (opcion != 6);
        }

        static void AgregarTarea(Queue<string> tareas, ref int listado)
        {
            string? asignatura, descripcion;
            do
            {
                Console.Clear();
                Console.WriteLine("**** AGREGAR TAREA ****");
                Console.WriteLine("Datos de la tarea");
                Console.Write("Asignatura: ");
                asignatura = Console.ReadLine();
                Console.Write("Descripción de la tarea: ");
                descripcion = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(asignatura) || !asignatura.All(c => char.IsLetter(c) || c == ' ') ||
                    string.IsNullOrWhiteSpace(descripcion))
                {
                    Console.WriteLine("ERORR. CAMPO VACÍO O DATOS NO ENTRADA NO PERMITIDA");
                    Console.WriteLine("Intente nuevamente...");
                    Console.WriteLine("Presione cualuquier tecla para continuar...");
                    Console.ReadKey();
                    continue;
                }
                string registro = $"****Tarea #{listado} ****" +
                                  $"\t{asignatura} - " +
                                  $"Descripción de tarea: {descripcion}";

                tareas.Enqueue(registro);
                listado++;
                Console.WriteLine("\nTarea agregada correctamente.");
                Console.WriteLine("Presione cualquier tecla para continuar...");
                Console.ReadKey();
                break;

            } while (true);
        }

        static void RealizarTarea(Queue<string> tareas)
        {
            Console.Clear();
            Console.WriteLine("**** TAREA REALIZADA ****");
            if (tareas.Count > 0)
            {
                string tarea_en_proceso = tareas.Dequeue();
                Console.WriteLine($"Tarea completada: \t{tarea_en_proceso}");
            }
            else
            {
                Console.WriteLine("No hay tareas por realizar.");
            }
            Console.WriteLine("Presione cualuquier tecla para continuar...");
            Console.ReadKey();
        }

        static void SiguienteTarea(Queue<string> tareas)
        {
            Console.Clear();
            Console.WriteLine("**** SIGUIENTE TAREA ****");
            if (tareas.Count > 0)
            {
                string proxima_tarea = tareas.Peek();
                Console.WriteLine($"Próxima tarea: \t{proxima_tarea}");
            }
            else
            {
                Console.WriteLine("No hay tareas por realizar.");

            }
            Console.WriteLine("Presione cualuquier tecla para continuar...");
            Console.ReadKey();
        }
        static void MostrarCantidad(Queue<string> tareas)
        {
            Console.Clear();
            Console.WriteLine("**** CANTIDAD DE TAREAS POR REALIZAR ****");
            if(tareas.Count > 0)
            {
                Console.WriteLine($"Tareas por realizar: {tareas.Count}");
            }
            else
            {
                Console.WriteLine("No hay tareas por realizar.");
            }
            Console.WriteLine("Presione cualuquier tecla para continuar...");
            Console.ReadKey();
        }

        static void MostrarTareas(Queue<string> tareas)
        {
            Console.Clear();
            Console.WriteLine("**** TAREAS PENDIENTES ****");
            if (tareas.Count > 0)
            {
                int i = 1;
                foreach(string tarea in tareas)
                {
                    Console.WriteLine($"{i}: \t{tarea}");
                    i++;
                }
            }
            else
            {
                Console.WriteLine("NO HAY TAREAS REGISTRADAS.");
            }
            Console.WriteLine("Presione cualuquier tecla para continuar...");
            Console.ReadKey();
        }
        static void CerrarPrograma()
        {
            Console.Clear();
            Console.WriteLine("Saliendo del programa...");
            Console.WriteLine("Presione cualuquier tecla para continuar...");
            Console.ReadKey();
            return;

        }
    }

        
}