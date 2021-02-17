using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5Database.Models
{
    public interface IBookRepository
    {   //sets the repository full of the projects (books) that it is able to run through
        IQueryable<Project> Projects { get; }
    }
}
