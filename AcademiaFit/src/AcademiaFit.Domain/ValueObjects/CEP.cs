using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaFit.Domain.ValueObjects
{
    public struct CEP
    {
        public int Numero { get; set; }

        public bool ValidaCEP()
        {
            return true;
        }
    }
}
