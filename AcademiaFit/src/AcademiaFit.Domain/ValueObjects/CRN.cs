using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaFit.Domain.ValueObjects
{
    public struct CRN
    {
        public int Numero { get; set; }

        public bool ValidaCRN()
        {
            return true;
        }
    }
}
