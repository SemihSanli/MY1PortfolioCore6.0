﻿using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;

namespace PortfolioCore.ViewComponents
{
    public class _DefaultStatsComponentPartial:ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
       public IViewComponentResult Invoke()
        {
            ViewBag.v1 = context.Testimonials.Count();
            ViewBag.v2 = context.Portfolios.Count();
            ViewBag.v3 = context.Skills.Count();
            Random random = new Random();
            int randomNumber = random.Next(10, 21); // 10 dahil, 21 hariç
            ViewBag.v4 = randomNumber;
            return View();
        }
    }
}
