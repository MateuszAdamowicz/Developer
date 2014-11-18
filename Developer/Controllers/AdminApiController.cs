using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Developer.Models.EntityModels;
using Developer.Models.EntityModels.Interfaces;

namespace Developer.Controllers
{
    public class AdminApiController : ApiController
    {
        private readonly IApplicationContext _context;

        public AdminApiController(IApplicationContext context)
        {
            _context = context;
        }

        public Worker GetWorkers()
        {

            return new Worker()
            {
                Id = 2,
                FirstName = "Mateusz",
                LastName = "Adamowicz",
                Email = "madamowicz@pgs-soft.com"
            };

        }

        public String Lol()
        {
            return "lol";
        }
    }
}
