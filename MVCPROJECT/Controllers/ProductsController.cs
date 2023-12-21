using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ThirdWebApp.Models;
using Catalog;

namespace ThirdWebApp.Controllers;

public class ProductsController : Controller
{
    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }

    public IActionResult ShowProduct()
    {
        Product p1=new Product();
        p1.Title="Jasmine";
        p1.Description="Smelling Flower";
        p1.UnitPrice=56;
        p1.Quantity=7999;
     p1.Imageurl="/images/Ac.jpg";
  
        ViewData["product"]=p1;
      //  return View();
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
