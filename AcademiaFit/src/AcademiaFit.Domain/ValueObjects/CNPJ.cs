using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaFit.Domain.ValueObjects
{
    public struct CNPJ
    {
        public int Numero { get; set; }

        public bool ValidaCNPJ()
        {
            return true;
        }
    }
}
