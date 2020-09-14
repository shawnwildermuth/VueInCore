using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VueInCore.Models;

namespace VueInCore.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class PeopleController : ControllerBase
  {
    public PeopleController()
    {

    }

    [HttpGet]
    public ActionResult<Person[]> Get()
    {
      return new Person[]
      {
        new Person()
        {
          Id = 1,
          FirstName = "Bob",
          LastName = "Smith",
          Phone = "404-555-1212"
        },
        new Person()
        {
          Id = 2,
          FirstName = "Jake",
          LastName = "Johnson",
          Phone = "404-555-1214"
        },
        new Person()
        {
          Id = 3,
          FirstName = "Alice",
          LastName = "Johntson",
          Phone = "404-555-1215"
        },
        new Person()
        {
          Id = 4,
          FirstName = "Phillip",
          LastName = "Trent",
          Phone = "404-555-1216"
        }
      };
    }
  }
}
