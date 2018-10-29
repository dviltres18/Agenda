using Microsoft.AspNetCore.Antiforgery;
using Agenda.Controllers;

namespace Agenda.Web.Host.Controllers
{
    public class AntiForgeryController : AgendaControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
