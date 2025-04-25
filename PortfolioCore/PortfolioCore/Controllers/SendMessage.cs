using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;
using PortfolioCore.Entities;

namespace PortfolioCore.Controllers
{
    public class SendMessage : Controller
    {
        PortfolioContext context = new PortfolioContext();
        [HttpPost]
        public IActionResult SendMessages(Message message)
        {

           context.Messages.Add(message);   
            context.SaveChanges();
            ViewBag.Success = "Gönderim işlemi başarılı!";
            return View("~/Views/Default/Index.cshtml");
        }
    }
}
