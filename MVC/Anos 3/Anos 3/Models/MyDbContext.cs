using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Anos_3.Models
{
    public class MyDbContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public MyDbContext():base("conn")
        {

        }
    }
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}