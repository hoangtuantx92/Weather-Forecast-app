using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API_Workshop.Controllers
{
    public class Person {
        public string Name { get; set; }
        public DateTime BirthDay { get ; set; }
    }

    [ApiController]
    [Route("[controller]")]
    public class BirthdayController{
        public BirthdayController()
        {
        }

        [HttpPost]
        public string Post(Person person){
            if(person.BirthDay == DateTime.Today)
            {
                return "Happy Birthday!";
            }
            return "It's not your birthday";
        }
    }
}