using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaFit.Domain.ValueObjects
{
    public struct CPF 
    {
        public int Numero { get; set; }

        public bool ValidaCPF()
        {
            return true;
        }
    }
}
