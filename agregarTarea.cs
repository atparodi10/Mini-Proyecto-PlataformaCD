using System;
using System.Collections.Generic;

namespace AgregarTareas
{
    internal class NuevaTarea
    {
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
    }
}