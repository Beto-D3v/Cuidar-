using Microsoft.AspNetCore.Mvc;
using ApiCuidar.Models;
using ApiCuidar.Data;
using Microsoft.EntityFrameworkCore;
using BCrypt.Net;

namespace ApiCuidar.Controllers
{
    [ApiController]
    [Route("usuariologin")]
    public class UsuarioLoginController: Controller
    {
        [HttpPost]
        [Route("")]
        public async Task<ActionResult<UsuarioLogin>> LoginUsuario([FromServices] DataContext context, [FromBody] UsuarioLogin body)
        {
            if(string.IsNullOrEmpty(body.Email) || string.IsNullOrEmpty(body.Senha))
            {
                throw new Exception("Digite e-mail e senha válidos para acessar o sistema!");
            }

            var usuario = await context.UsuarioLogins.FirstOrDefaultAsync(x => x.Email == body.Email);

            if(usuario == null || !BCrypt.Net.BCrypt.Verify(body.Senha, usuario.Senha))
            {
              throw new Exception("O e-mail e/ou a senha estão incorretos!");
            }

           // return View("");
           return body;
        }

    }
}