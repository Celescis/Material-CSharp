using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Ejemplo_Hilos_2
{
    class Program
    {
        private static Random random;

        static void Main(string[] args)
        {
            random = new Random();

            Task hiloSinc = Task.Run(EjecutarSincrónico);
            Task hiloParallel = Task.Run(EjecutarEnParalelo);

            Task.WaitAll(hiloSinc, hiloParallel);

            Console.WriteLine("¡FINALIZARON TODAS LAS TAREAS!");
        }

        public static void EjecutarEnParalelo()
        {
            Queue<Action> tareas = new Queue<Action>();
            tareas.Enqueue(() => EjecutarTarea("PARALLEL-A"));
            tareas.Enqueue(() => EjecutarTarea("PARALLEL-B"));
            tareas.Enqueue(() => EjecutarTarea("PARALLEL-C"));
            tareas.Enqueue(() => EjecutarTarea("PARALLEL-D"));
            tareas.Enqueue(() => EjecutarTarea("PARALLEL-E"));
            tareas.Enqueue(() => EjecutarTarea("PARALLEL-F"));
            tareas.Enqueue(() => EjecutarTarea("PARALLEL-G"));
            tareas.Enqueue(() => EjecutarTarea("PARALLEL-H"));
            tareas.Enqueue(() => EjecutarTarea("PARALLEL-I"));
            tareas.Enqueue(() => EjecutarTarea("PARALLEL-J"));
            tareas.Enqueue(() => EjecutarTarea("PARALLEL-K"));
            tareas.Enqueue(() => EjecutarTarea("PARALLEL-L"));
            tareas.Enqueue(() => EjecutarTarea("PARALLEL-M"));
            tareas.Enqueue(() => EjecutarTarea("PARALLEL-N"));

            foreach (Action tarea in tareas)
            {
                Task.Run(tarea);
            }
        }

        public static void EjecutarSincrónico()
        {
            Queue<Action> tareas = new Queue<Action>();
            tareas.Enqueue(() => EjecutarTarea("SINC-A"));
            tareas.Enqueue(() => EjecutarTarea("SINC-B"));
            tareas.Enqueue(() => EjecutarTarea("SINC-C"));
            tareas.Enqueue(() => EjecutarTarea("SINC-D"));
            tareas.Enqueue(() => EjecutarTarea("SINC-E"));
            tareas.Enqueue(() => EjecutarTarea("SINC-F"));
            tareas.Enqueue(() => EjecutarTarea("SINC-G"));
            tareas.Enqueue(() => EjecutarTarea("SINC-H"));
            tareas.Enqueue(() => EjecutarTarea("SINC-I"));
            tareas.Enqueue(() => EjecutarTarea("SINC-J"));
            tareas.Enqueue(() => EjecutarTarea("SINC-K"));
            tareas.Enqueue(() => EjecutarTarea("SINC-L"));
            tareas.Enqueue(() => EjecutarTarea("SINC-M"));
            tareas.Enqueue(() => EjecutarTarea("SINC-N"));

            foreach (Action tarea in tareas)
            {
                tarea();
            }
        }

        public static void EjecutarTarea(string codigo)
        {
            int tiempo = random.Next(1000, 5000);
            Thread.Sleep(tiempo);
            Console.WriteLine($"{DateTime.Now:T} - Hilo N°{Task.CurrentId} - Tarea {codigo} completada en {tiempo} ms.");
        }
    }
}
