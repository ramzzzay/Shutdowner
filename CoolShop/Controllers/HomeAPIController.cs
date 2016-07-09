using System;
using System.Collections.Generic;
using System.Web.Http;
using CoolShop.Models;

namespace CoolShop.Controllers
{
    public class HomeAPIController : ApiController
    {
        private readonly List<Human> humans = new List<Human>
        {
            new Human {Id = 0, Name = "Victor", BorneDate = new DateTime(1, 2, 3)},
            new Human {Id = 1, Name = "Angelo", BorneDate = new DateTime(3, 2, 1)},
            new Human {Id = 2, Name = "Margaret", BorneDate = new DateTime(2, 1, 3)}
        };

        public List<Human> GetHumans()
        {
            return humans;
        }
    }
}