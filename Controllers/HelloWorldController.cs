using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using netpractice1.Models;

namespace netpractice1.Controllers;

public class HelloWorldController : Controller{

    public IActionResult Index()
    {
        DogViewModel doggo = new DogViewModel(){
            Name = "Gucci", Age = 2
        };

        return View(doggo);
    }

    public IActionResult Create(){
        //before we load the page, we want to make a new dogVm object where the data will be binded to it from the form
        var dogVm = new DogViewModel();
        return View(dogVm);
    }

    public IActionResult CreateDog(DogViewModel dogViewModel){
        return View("Index");
    }

}
