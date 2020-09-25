using AutoMapper;
using IntercambioMedicina.Domain.Entities;
using IntercambioMedicinaDDD.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntercambioMedicinaDDD.Automapper
{
    public class DomainToViewModelMappingProfile : Profile
    {

        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            CreateMap<AlunoViewModel, Aluno>();
            CreateMap<CursoViewModel, Curso>();
        }

    }
}