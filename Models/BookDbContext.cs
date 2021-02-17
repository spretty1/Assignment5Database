using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5Database.Models
{
    public class BookDbContext: DbContext 
    {
        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options)
        {

        }
        //sets the database to hold the projects
        public DbSet<Project> Projects { get; set; }
    }
}
