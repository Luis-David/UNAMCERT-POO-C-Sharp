using System;
using System.Collections.Generic;
using System.Text;

namespace ExploradorDeArchivos
{
    class ExcepcionNumArgumentos:Exception
    {
        public ExcepcionNumArgumentos(string msj) : base(msj) { }
    }
}
