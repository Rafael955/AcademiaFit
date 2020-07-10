using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaFit.Domain.ValueObjects
{
    public struct CREF 
    {
        public int Numero { get; set; }

        public bool ValidaCREF()
        {
            return true;
        }
    }
}
