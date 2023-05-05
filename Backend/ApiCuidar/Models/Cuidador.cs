using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ApiCuidar.Models
{
    public class Cuidador
    {
        [Key]
        public int Id{get;set;}
        [Required(ErrorMessage = "O nome é obrigatório")]
        [MinLength(5, ErrorMessage = "O nome deve ter pelo menos 5 caracteres!")]
        public string? Name{get;set;}
        public string? EmailAddress{get;set;}
        [Required(ErrorMessage = "O CPF é obrigatório")]
        [MinLength(11, ErrorMessage = "O CPF deve ter pelo menos 11 caracteres!")]
        public string? Cpf{get;set;}
        [Display(Name = "Data Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        [Required(ErrorMessage = "{0} required")]
        public DateTime BirthDate{get;set;}
        public string? Phone{get;set;}
        public string? State{get;set;}
        public string? City{get;set;}
        [Required(ErrorMessage = "O preenchimento da sua área de atuação é obrigatório!")]
        public string? Profession{get;set;}
        [Required(ErrorMessage = "O valor por hora é obrigatório!")]
        public double DayValue{get;set;}
        [Required(ErrorMessage = "O valor por hora é obrigatório!")]
        public double NightValue{get;set;}
        [Required(ErrorMessage = "O número de validação do profissional é obrigatório!")]
        public string? ProfessionalNumber{get;set;}
        public string? Presentation{get;set;}
        [MinLength(8, ErrorMessage = "A senha deve ter pelo menos 8 caracteres!")]
        public string Password{get;set;}

    }
}