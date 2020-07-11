using Flunt.Notifications;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaFit.Domain.ValueObjects
{
    public class CREF : Notifiable
    {
        public CREF(string codigo)
        {
            Codigo = codigo;

            AddNotifications(new Contract()
                .Requires()
                .HasMaxLen(Codigo, 11, "Codigo", "CREF Inválido"));
        }

        public string Codigo { get; private set; }
    }
}
