using Microsoft.AspNetCore.Antiforgery;
using assignment.Controllers;

namespace assignment.Web.Host.Controllers
{
    public class AntiForgeryController : assignmentControllerBase
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
