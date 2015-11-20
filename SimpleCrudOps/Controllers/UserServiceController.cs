using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SimpleCrudOps.Data;
using SimpleCrudOps.Models;

namespace SimpleCrudOps.Controllers
{
    public class UserServiceController : ApiController
    {
        private DataContext context;

        public UserServiceController()
        {
            this.context = new DataContext();
        }

        [HttpPost]
        public int AddUser(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
            return user.UserId;
        }

        [HttpGet]
        public User GetUser(int id)
        {
            User user = context.Users.Find(id);
            return user;
        }

        [HttpGet]
        public List<User> GetUsersList()
        {
            return context.Users.ToList();
        }

        [HttpPut]
        public void ModifyUser(User user, int id)
        {
            if (user.UserId == id)
            {
                context.Entry(user).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        [HttpDelete]
        public void DeleteUser(int id)
        {
            User user = context.Users.Find(id);
            if (user != null)
            {
                context.Users.Remove(user);
                context.SaveChanges();
            }
        }
    }
}
