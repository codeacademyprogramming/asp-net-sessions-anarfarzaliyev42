namespace OnlineEduWebApp.Contexts
{
    using OnlineEduWebApp.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class UserContext : DbContext
    {

        public UserContext()
            : base("name=UserContext")
        {
        }


         public  DbSet<User> Users { get; set; }
    }

 
}