using System.ComponentModel.DataAnnotations;


namespace ApiCuidar.Models
{
    public class UsuarioLogin
    {
        [Key]
        public int Id{get;set;}
        public string? Email{get;set;}
        [MinLength(8, ErrorMessage = "A senha deve ter pelo menos 8 caracteres!")]
        public string Senha{get;set;}

    }
}