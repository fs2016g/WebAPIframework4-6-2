using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIframework4_6_2.Models;

namespace WebAPIframework4_6_2.Controllers
{
    public class PeopleController : ApiController
    {

        List<Person> people = new List<Person>();
        public PeopleController()
        {

            people.Add(new Person { FirstName = "John", LastName = "Doe", Id = 1 });
            people.Add(new Person { FirstName = "Tom", LastName = "Harrison", Id = 2 });
            people.Add(new Person { FirstName = "Jill", LastName = "Jackson", Id = 3 });

        }
        // GET: api/People
        public List<Person> Get()
        {
            return people;
        }

        // GET: api/People/5
        public Person Get(int id)
        {
            return people.Where(x => x.Id == id).FirstOrDefault();
        }

        // POST: api/People
        public void Post(Person val)
        {
            people.Add(val);
        }

        // DELETE: api/People/5
        public void Delete(int id)
        {
            
        }
    }
}
