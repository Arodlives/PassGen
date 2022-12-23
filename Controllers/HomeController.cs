using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PassGen.Models;
using Microsoft.AspNetCore.Http;

namespace PassGen.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
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



    [HttpGet("")]
    public IActionResult GeneratePassword()
    {
        //  left  is  key  and right is value
        int? ClickCount = HttpContext.Session.GetInt32("Count");
        
        if (ClickCount == null)
        {
            HttpContext.Session.SetInt32("Count",1);
            //Todo -  To  access function from a model Call on Class.Method() 
            HttpContext.Session.SetString("NewPassword",PassGener.RandomPassword());
        }
        else
        {
            //* Clear is for  all , Remove is for one
            HttpContext.Session.SetInt32("Count",(int)ClickCount+1);
            
            HttpContext.Session.SetString("NewPassword",PassGener.RandomPassword());
        }
        return View("Index");
    }













}
