using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiAuthentication.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {

        [HttpGet]
        [Route("anonymous")]
        [AllowAnonymous]
        public string Anonymous() => "Anonimo";

        [HttpGet]
        [Route("authenticated")]
        [Authorize]
        public string Authenticated() => string.Format("Autenticado - {0}", User.Identity.Name);


        [HttpGet]
        [Route("employee")]
        [Authorize(Roles = "admin,manager,employee")]
        public string Employee() => string.Format("Funcionario - {0}", User.Identity.Name);

        [HttpGet]
        [Route("manager")]
        [Authorize(Roles = "admin,manager")]
        public string Manager() => string.Format("Gerente - {0}", User.Identity.Name);

        [HttpGet]
        [Route("admin")]
        [Authorize(Roles = "admin")]
        public string Admin() => string.Format("Administrador - {0}", User.Identity.Name);
    }
}
