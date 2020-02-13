using System;
using System.Collections.Generic;
using System.Text;

namespace ExploradorDeArchivos
{
    class ExcepcionComandoNoEncontrado:Exception
    {
        public ExcepcionComandoNoEncontrado(string msj): base(msj)
        {

        }
    }
}
