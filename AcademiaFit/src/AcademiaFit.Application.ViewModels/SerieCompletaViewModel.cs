using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaFit.Application.ViewModels
{
    public class SerieCompletaViewModel
    {
        public Guid ProfessorResponsavelId { get; set; }
        public Guid AlunoId { get; set; }
        public List<ItemSerieViewModel> ItensSerie { get; set; }
    }
}
