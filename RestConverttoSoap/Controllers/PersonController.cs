using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RestConverttoSoap.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        [HttpGet]
        [Route("GetAllPerson")]
        public IEnumerable<Person> GetAllPerson()
        {
            return new List<Person>(new[]
            {
                new Person{Id=1,Name="name1",Surname="surname1"},
                new Person{Id=2,Name="name2",Surname="surname2"},
                new Person{Id=3,Name="name3",Surname="surname3"},
                new Person{Id=4,Name="name4",Surname="surname4"},
                new Person{Id=5,Name="name5",Surname="surname5"},
                new Person{Id=6,Name="name6",Surname="surname6"}
         });
        }
    }
}
