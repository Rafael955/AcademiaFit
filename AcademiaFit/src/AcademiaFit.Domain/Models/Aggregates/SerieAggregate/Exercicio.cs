﻿using AcademiaFit.Domain.Models.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaFit.Domain.Models.Aggregates.SerieAggregate
{
    public class Exercicio : Entidade
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
    }
}
