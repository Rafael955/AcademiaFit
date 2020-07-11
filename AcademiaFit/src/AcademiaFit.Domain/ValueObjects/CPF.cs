﻿using Flunt.Notifications;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaFit.Domain.ValueObjects
{
    public class CPF : Notifiable
    {
        public CPF(string numero)
        {
            Numero = numero;

            AddNotifications(new Contract()
                .Requires()
                .HasMaxLen(Numero, 14, "CPF.Numero", "CPF Inválido"));
        }

        public string Numero { get; private set; }
    }
}
