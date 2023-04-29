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
        public string? Nome{get;set;}
        public string? Email{get;set;}
        [Required(ErrorMessage = "O CPF é obrigatório")]
        [MinLength(11, ErrorMessage = "O CPF deve ter pelo menos 11 caracteres!")]
        public string? Cpf{get;set;}
        [Display(Name = "Data Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        [Required(ErrorMessage = "{0} required")]
        public DateTime DataNascimento{get;set;}
        public string? Telefone{get;set;}
        [Required(ErrorMessage = "O preenchimento do CEP é obrigatório!")]
        [MinLength(8, ErrorMessage = "O CEP deve ter pelo menos 8 caracteres!")]
        public string? Cep{get;set;}
        public string? Estado{get;set;}
        public string? Cidade{get;set;}
        [Required(ErrorMessage = "O preenchimento da sua área de atuação é obrigatório!")]
        public string? AreaAtuacao{get;set;}
        [Required(ErrorMessage = "O valor por hora é obrigatório!")]
        public double ValorHora{get;set;}
        [Required(ErrorMessage = "O número de validação do profissional é obrigatório!")]
        public string? NumeroProfissional{get;set;}
        [MinLength(8, ErrorMessage = "A senha deve ter pelo menos 8 caracteres!")]
        public string Senha{get;set;}

    }
}