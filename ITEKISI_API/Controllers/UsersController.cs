using ITEKISI_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ITEKISI_API.Controllers
{
    [Authorize]
    public class UsersController : ApiController
    {

        List<User> UsersData = new List<User>();
    
        public UsersController ()
        {
            UsersData.Add(new User { Id = 1, Username = "admin@mail.com", Password = "Admin123@" });
            UsersData.Add(new User { Id = 2, Username = "mbuzi@mail.com", Password = "Admin123@" });
            UsersData.Add(new User { Id = 3, Username = "dawgen@mail.com", Password = "Admin123@" });
        }

        [Route]
        [HttpGet]
        // GET: api/GetUsernames
        public List<string> GetUsernames()
        {
            List<string> results = new List<string>();
            foreach(var p in UsersData)
            {
                results.Add(p.Username);
            }
            return results;
        }

        // GET: api/Users
        public List<User> Get()
        {
            return UsersData;
        }

        // GET: api/Users/5
        public User Get(int id)
        {
            return UsersData.Where(x => x.Id == id).FirstOrDefault();
        }

        // POST: api/Users
        public void Post(User val)
        {
            UsersData.Add(val);
        }

        // PUT: api/Users/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Users/5
        public void Delete(User val)
        {
            UsersData.Remove(val);
        }
    }
}
