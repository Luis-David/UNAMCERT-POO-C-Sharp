using System;

namespace Tarea2CalificandoAlumnos
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            Console.WriteLine("Ingrese el número de alumnos a calificar: ");
            int numeroAlumnos = Convert.ToInt32(Console.ReadLine());
            Alumno[] alumnos = new Alumno[numeroAlumnos];
            Evaluacion[] evaluaciones = new Evaluacion[numeroAlumnos];
            

                for (int i=0; i<numeroAlumnos; i++)
            {
                alumnos[i] = new Alumno();
                Console.WriteLine("Ingrese el nombre del alumno:");
                alumnos[i].Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese los apellidos del alumno:");

                alumnos[i].Apellidos = Console.ReadLine();
                Console.WriteLine("Ingrese la fecha de nacimiento(dd/mm/aa):");
                alumnos[i].FechaDeNacimiento = Console.ReadLine();
                evaluaciones[i] = new Evaluacion();
                evaluaciones[i].CalifProyecto = rd.Next(5,11);
                evaluaciones[i].NumTareas = rd.Next(1, 6);
                evaluaciones[i].CalifProyecto = rd.Next(0, 20);
            }
            //Calificamos al alumno:
            for(int i=0; i<numeroAlumnos; i++)
            {
                Calculadora(alumnos[i], evaluaciones[i]);
            }


        }
        static void Calculadora(Alumno alumno,Evaluacion evaluacion)
        {
            double calificacionFinal = 0;
            calificacionFinal = evaluacion.CalifProyecto * 6;
            calificacionFinal = calificacionFinal + evaluacion.NumTareas * 8;
            if(evaluacion.NumParticipaciones > 5)
            {
                calificacionFinal += 8;
            }
            if (calificacionFinal < 50)
            {
                calificacionFinal = 50;
            }
            Console.WriteLine("La calificación final de {0} {1} es de {2}/100", alumno.Nombre,
                alumno.Apellidos, calificacionFinal);
        }
    }
}
