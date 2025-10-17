using System;
using System.Collections.Generic;

namespace Marcartarea
{
    internal class funcionRealizarTarea
    {
        static void RealizarTarea(Queue<string> tareas)
        {
            Console.Clear();
            Console.WriteLine("** TAREA REALIZADA **");
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
    }
}