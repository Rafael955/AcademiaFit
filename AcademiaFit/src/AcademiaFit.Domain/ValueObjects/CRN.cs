﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaFit.Domain.ValueObjects
{
    public class CRN
    {
        public int Numero { get; set; }

        public bool ValidaCRN()
        {
            return true;
        }
    }
}
