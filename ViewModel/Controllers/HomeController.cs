using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ViewModel.Models;

namespace ViewModel.Controllers
{
    public class HomeController : Controller
    {
        public List<User> GenerateUsers()
        {
            return new List<User>()
            {
                new User(){ FirstName="Moose", LastName="Phillips"},
                new User(){ FirstName="Sarah", LastName="McLachlein"},
                new User(){ FirstName="Ricky", LastName="Bobby"},
                new User(){ FirstName="John", LastName="Johnson"},
            };
        }
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            string stringModel = "This is a message!";

            return View("Index", stringModel);
        }
        [HttpGet("numbers")]
        public IActionResult Numbers()
        {
            int[] numbers = new int[] { 1, 2, 5, 4, 6, 54, 69, 3 };
            return View(numbers);
        }
        [HttpGet("users")]
        public IActionResult AllUsers()
        {
            var users = GenerateUsers();
            return View(users);
        }
        [HttpGet("user")]
        public IActionResult OneUser()
        {
            var rand = new Random();
            var users = GenerateUsers();

            // grab random user (could just create one, grab first, etc...)
            var user = users[rand.Next(users.Count)];
            return View(user);
        }
    }

}

