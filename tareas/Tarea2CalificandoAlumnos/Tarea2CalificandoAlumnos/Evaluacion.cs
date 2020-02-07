using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea2CalificandoAlumnos
{
    class Evaluacion
    {
        float califProyecto;
        int numTareas;
        int numParticipaciones;

        public float CalifProyecto
        {
            set { califProyecto = value; }
            get { return califProyecto; }
        }

        public int NumTareas
        {
            set{
                    numParticipaciones = value;
            }
            get { return numTareas; }
        }
        public int NumParticipaciones
        {
            set { numTareas = value; }
            get { return numParticipaciones; }
        }

    }
}
