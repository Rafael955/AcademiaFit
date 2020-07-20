using AcademiaFit.Application.ViewModels;
using AcademiaFit.Domain.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaFit.Infrastructure.Data.AutoMapper
{
    public class AutoMapperConfig
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(ps =>
            {
                ps.AddProfile<DomainToViewModelMapping>();
                ps.AddProfile<ViewModelToDomainMapping>();
            });
        }
    }
}
