using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using LuckySpin.Models;
using LuckySpin.Services;
using Microsoft.VisualBasic;

namespace LuckySpin.Controllers
{
    public class SpinnerController : Controller
    {
        //DIJ in 4 STEPS -
        //DONE: 0) Register the Repository class as a service in Program.cs 
        //DONE: 1) add an instance variable here of type Repository
        private Repository repository;

        /***
         * Constructor - DONE: 2) call for a DIJ Repository object to be passed to the constructor
         **/
        public SpinnerController(Repository repositoryDIJ)
        {
            //DONE: 3) save the DIJ Repository object into your instance variable
            repository = repositoryDIJ;
        }

        /***
         * Index Action
         **/
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Player player)
        {
            if(!ModelState.IsValid) { return View(); }

            return RedirectToAction("Spin", player);
        }

        /***
         * Spin Action
         **/  
               
        public IActionResult Spin(Player player)
        {
            //Create a new Spin with the player
            Spin spin = new Spin { Player = player };
            //DONE: Add to LuckList
            repository.AddSpin(spin);

            return View("Spin", spin);
        }

        /***
         * ListSpins Action
         **/
        [HttpGet]
        public IActionResult LuckList()
        {
                //DONE: Pass the repository's Player Spins to the LuckList View

                return View(repository.PlayerSpins);
        }

    }
}

