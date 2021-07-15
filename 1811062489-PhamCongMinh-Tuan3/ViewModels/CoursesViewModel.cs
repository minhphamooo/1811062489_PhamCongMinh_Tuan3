using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _1811062489_PhamCongMinh_Tuan3.Models;

namespace _1811062489_PhamCongMinh_Tuan3.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}