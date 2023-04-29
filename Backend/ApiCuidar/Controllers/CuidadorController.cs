using Microsoft.AspNetCore.Mvc;
using ApiCuidar.Models;
using ApiCuidar.Data;
using Microsoft.EntityFrameworkCore;

namespace ApiCuidar.Controllers
{
    [ApiController]
    [Route("cuidadores")]
    public class CuidadorController: Controller
    {
        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Cuidador>> Cadastrar([FromServices] DataContext context, [FromBody] Cuidador body)
        {
            if(!ModelState.IsValid)
            {
                BadRequest(ModelState);
            }

            var senhaHash = BCrypt.Net.BCrypt.HashPassword(body.Senha);

            var cuidador = new Cuidador()
            {
                Nome = body.Nome,
                Email = body.Email,
                Cpf = body.Cpf,
                DataNascimento = body.DataNascimento,
                Telefone = body.Telefone,
                Cep = body.Cep,
                Estado = body.Estado,
                Cidade = body.Cidade,
                AreaAtuacao = body.AreaAtuacao,
                ValorHora = body.ValorHora,
                NumeroProfissional = body.NumeroProfissional,
                Senha = senhaHash
            };

            var usuarioLogin = new UsuarioLogin()
            {
                 Email = body.Email,
                 Senha = senhaHash
            };


             context.Cuidadores.Add(cuidador);
             context.UsuarioLogins.Add(usuarioLogin);
             await context.SaveChangesAsync();

             return body; 

        }

        [HttpGet]
        public async Task<ActionResult<List<Cuidador>>> Listar([FromServices] DataContext context)
        {
            var cuidadores = await context.Cuidadores.ToListAsync();
            return cuidadores;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Cuidador>> Buscar([FromServices] DataContext context, int id)
        {
            var cuidador = await context.Cuidadores.FindAsync(id);

            if (cuidador == null)
            {
                return NotFound();
            }

            return cuidador;
        }

    }
}