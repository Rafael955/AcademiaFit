using Flunt.Notifications;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaFit.Domain.ValueObjects
{
    public class CNPJ : Notifiable
    {
        public CNPJ(string numero)
        {
            Numero = numero;

            AddNotifications(new Contract()
                .Requires()
                .HasMaxLen(Numero, 14, "CNPJ.Numero", "CNPJ Inválido"));
        }

        public string Numero { get; private set; }
    }
}
