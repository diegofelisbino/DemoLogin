using DemoLogin.Extensions;
using DemoLogin.Repositories;
using DemoLogin.Services;
using DemoLogin.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoLogin.Controllers
{
    [ApiController]
    public class ContaController : ControllerBase
    {
        private readonly UsuarioRepository _usuarioRepository;
        private readonly TokenService _tokenService;

        public ContaController(UsuarioRepository usuarioRepository, TokenService tokenService)
        {
            _usuarioRepository = usuarioRepository;
            _tokenService = tokenService;
        }


        [HttpPost("/v1/contas/login")]
        [AllowAnonymous]
        public IActionResult Login([FromBody] LoginViewModel model)
        {
            if (!ModelState.IsValid) return BadRequest();

            var usuario = _usuarioRepository.Get(model.Email);

            if (usuario == null)
                return Unauthorized(new { erro = "Usuário ou senha inválidos" });
            
            if (usuario.Senha != model.Senha)
                return Unauthorized(new { erro = "Usuário ou senha inválidos" });

            var token = new { access_token = _tokenService.GenerateToken(usuario) };
            return Ok(token);
        }

        [HttpGet("/v1/contas/admin")]
        [Authorize(Roles = "admin")]
        public IActionResult GetAdmin()
        {
            return Ok();
        }

        [HttpGet("/v1/contas/user")]
        [Authorize(Roles = "user, admin")]
        public IActionResult GetUer()
        {
            return Ok();
        }
    }
}
