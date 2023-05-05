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
            if(string.IsNullOrEmpty(body.EmailAddress) || string.IsNullOrEmpty(body.Password))
            {
                throw new Exception("Digite e-mail e senha válidos para acessar o sistema!");
            }

            var usuario = await context.UsuarioLogins.FirstOrDefaultAsync(x => x.EmailAddress == body.EmailAddress);

            if(usuario == null || !BCrypt.Net.BCrypt.Verify(body.Password, usuario.Password))
            {
              throw new Exception("O e-mail e/ou a senha estão incorretos!");
            }

           // return View("");
           return body;
        }

    }
}