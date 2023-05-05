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
                return NotFound();
            }

            var HashPassword = BCrypt.Net.BCrypt.HashPassword(body.Password);

            var cpf = await context.Cuidadores.FirstOrDefaultAsync(x => x.Cpf == body.Cpf);

            var email = await context.Cuidadores.FirstOrDefaultAsync(x => x.EmailAddress == body.EmailAddress);

            if(cpf != null || email != null)
            {
                return BadRequest("Usuário já cadastrado no sistema!");
            }

            else
            {
                 var cuidador = new Cuidador()
                {
                    Name = body.Name,
                    EmailAddress = body.EmailAddress,
                    Cpf = body.Cpf,
                    BirthDate = body.BirthDate,
                    Phone = body.Phone,
                    State = body.State,
                    City = body.City,
                    Profession = body.Profession,
                    DayValue = body.DayValue,
                    NightValue = body.NightValue,
                    ProfessionalNumber = body.ProfessionalNumber,
                    Presentation = body.Presentation,
                    Password = HashPassword
                };

                var usuarioLogin = new UsuarioLogin()
                {
                    EmailAddress = body.EmailAddress,
                    Password = HashPassword
                };


                context.Cuidadores.Add(cuidador);
                context.UsuarioLogins.Add(usuarioLogin);
                await context.SaveChangesAsync();

                return body;

            }

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