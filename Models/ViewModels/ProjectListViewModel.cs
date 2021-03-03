using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5Database.Models.ViewModels
{
    public class ProjectListViewModel
    {   //sets the project list view model for the ienumerable list of projects and paging info 
        public IEnumerable<Project> Projects { get; set; }
        public PagingInfo PagingInfo { get; set; }
        //holds what category is currently selected
        public string CurrentCategory { get; set; }
    }
}
