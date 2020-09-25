using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IntercambioMedicinaDDD.ViewModels
{
    public class CursoViewModel
    {
        [Key]
        public int CursoId { get; set; }


        [Required(ErrorMessage = "Prencha o campo Nome")]
        [MaxLength(250, ErrorMessage = "Maximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string Nome { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "999999999999")]
        [Required(ErrorMessage = "Prencha o valor")]
        public decimal Valor{ get; set; }

        [DisplayName("Disponivel?")]
        public bool Disponivel { get; set; }

        
        public int AlunoId { get; set; }

        public virtual AlunoViewModel Aluno { get; set; }

        


    }
}