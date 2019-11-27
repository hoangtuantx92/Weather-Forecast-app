using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API_Workshop.Controllers
{
    public class Customer {
        public String FirstName {get; set;}
        public String LastName {get; set;}
        public int CustomerId {get; set;}
    }

    [ApiController]
    [Route("[controller]")]
    public class CustomerController {

    }

}