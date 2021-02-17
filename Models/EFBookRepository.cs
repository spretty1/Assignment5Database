using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5Database.Models
{
    public class EFBookRepository : IBookRepository
    {
        private BookDbContext _context;

        //Constructor for setting the context 
        public EFBookRepository(BookDbContext context)
        {
            _context = context;
        }
        public IQueryable<Project> Projects => _context.Projects;
    }
}
