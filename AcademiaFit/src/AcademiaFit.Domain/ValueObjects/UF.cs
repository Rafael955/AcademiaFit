using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaFit.Domain.ValueObjects
{
    public class UF
    {
        public string UnidadeFederativa { get; set; }

        private bool ValidaUF()
        {
            return true;
        }
    }
}
