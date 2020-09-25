using AutoMapper;
using IntercambioMedicina.Domain.Entities;
using IntercambioMedicinaDDD.ViewModels;

namespace IntercambioMedicinaDDD.Automapper
{

    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            CreateMap<Aluno, AlunoViewModel>();
            CreateMap<Curso, CursoViewModel>();
        }

    }
}