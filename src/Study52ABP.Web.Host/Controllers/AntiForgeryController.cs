using Microsoft.AspNetCore.Antiforgery;
using Study52ABP.Controllers;

namespace Study52ABP.Web.Host.Controllers
{
    public class AntiForgeryController : Study52ABPControllerBase
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
