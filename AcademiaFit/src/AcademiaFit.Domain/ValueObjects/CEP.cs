using Flunt.Notifications;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaFit.Domain.ValueObjects
{
    public class CEP : Notifiable 
    {
        public CEP(string numero)
        {
            Numero = numero;

            AddNotifications(new Contract()
                .Requires()
                .HasMaxLen(Numero, 8, "CEP.Numero", "CEP Inválido"));
        }

        public string Numero { get; private set; }
    }
}
