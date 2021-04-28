using ControleFinanceiro.api.Filters;
using ControleFinanceiro.api.Models;
using ControleFinanceiro.api.Models.Usuarios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleFinanceiro.api.Controllers
{
    [Route("api/v1/usuario")] //versionei a API
    [ApiController]
    public class UsuarioController : ControllerBase

    {   //Mensagem swagger no localhost
        [SwaggerResponse(statusCode: 200, description: "Sucesso ao autenticar", Type = typeof(LoginViewModelInput ))]
        [SwaggerResponse(statusCode: 400, description: "Erro Interno", Type = typeof(ErroGenericoViewModel))]


        [HttpPost] // verbo post da api rest
        [Route("logar")]
        [ValidacaoModelStateCustomizado] //config do filtro validacao

        public IActionResult Logar(LoginViewModelInput loginViewModelInput)
        {
            
            return Ok( loginViewModelInput);
        }

        [HttpPost] // verbo post da api rest
        [Route("registrar")]
        [ValidacaoModelStateCustomizado] //config do filtro validacao

        public IActionResult Registrar(RegistroViewModelinput loginViewModelInput)
        {
            return Created("", loginViewModelInput);
        }
    }
}
