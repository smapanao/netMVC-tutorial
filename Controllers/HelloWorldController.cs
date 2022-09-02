using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using netpractice1.Models;

namespace netpractice1.Controllers;

public class HelloWorldController : Controller{

    //since we're not using a database, we will just temporarily use a list
    private static List<DogViewModel> dogs = new List<DogViewModel>();

    //view index page
    public IActionResult Index()
    {
   
        return View(dogs);
    }

    //this method allows us to view the form
    public IActionResult Create(){
        //before we load the page, we want to make a new dogVm object where the data will be binded to it from the form
        //returns to the view in the HelloWorld folder, that conatins a Create.cshtml
        var dogVm = new DogViewModel();
        return View(dogVm);
    }

    //this method allows us to bind the information 
    public IActionResult CreateDog(DogViewModel dogViewModel){
        
        //add the current args to list
        dogs.Add(dogViewModel);

        //this returns to the index view method 
        return RedirectToAction(nameof(Index));
        
        //below returns to the chtml
        //return View("Index");
    }

}
