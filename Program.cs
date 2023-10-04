using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tarea2._5
{
    using System;

    class Program
    {
        static void Main()
        {
            // variables
            string carnet, nombre;
            double quiz1, quiz2, quiz3, tarea1, tarea2, tarea3, examen1, examen2, examen3;

            // Solicitar datos al usuario
            Console.WriteLine("Ingrese el carnet del estudiante:");
            carnet = Console.ReadLine();

            Console.WriteLine("Ingrese el nombre del estudiante:");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese la calificación del Quiz 1:");
            quiz1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la calificación del Quiz 2:");
            quiz2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la calificación del Quiz 3:");
            quiz3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la calificación de la Tarea 1:");
            tarea1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la calificación de la Tarea 2:");
            tarea2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la calificación de la Tarea 3:");
            tarea3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la calificación del Examen 1:");
            examen1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la calificación del Examen 2:");
            examen2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la calificación del Examen 3:");
            examen3 = double.Parse(Console.ReadLine());

            // Calculo de porcentajes
            double porcentajeQuices = (quiz1 + quiz2 + quiz3) / 3 * 0.25;
            double porcentajeTareas = (tarea1 + tarea2 + tarea3) / 3 * 0.3;
            double porcentajeExamenes = (examen1 + examen2 + examen3) / 3 * 0.45;

            // Calcular promedio final
            double promedioFinal = porcentajeQuices + porcentajeTareas + porcentajeExamenes;

            // Determinar condición del estudiante
            string condicion = (promedioFinal >= 70) ? "Aprobado" : (promedioFinal >= 50) ? "Aplazado" : "Reprobado";

            // Mostrar resultados
            Console.WriteLine("\nResultados:");
            Console.WriteLine("Carnet: " + carnet);
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Porcentaje de Quices: " + porcentajeQuices.ToString("P"));
            Console.WriteLine("Porcentaje de Tareas: " + porcentajeTareas.ToString("P"));
            Console.WriteLine("Porcentaje de Examenes: " + porcentajeExamenes.ToString("P"));
            Console.WriteLine("Promedio Final: " + promedioFinal.ToString("F2"));
            Console.WriteLine("Condición: " + condicion);
        }
    }



}

