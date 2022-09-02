using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using netpractice1.Models;

namespace netpractice1.Controllers;

public class TestController : Controller{

    public IActionResult Index()
    {
        
        return View();
    }

    public string Test(){
        return "This is an action";
    }

}
