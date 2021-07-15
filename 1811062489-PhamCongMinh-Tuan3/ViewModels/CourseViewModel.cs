using _1811062489_PhamCongMinh_Tuan3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using _1811062489_PhamCongMinh_Tuan3.ViewModels;

namespace _1811062489_PhamCongMinh_Tuan3.ViewModels
{
    public class CourseViewModel
    {
        [Required]
        public string Place { get; set; }

        public int Id { get; set; }

        public string Date { get; set; }
      
        public string Time { get; set; }
        
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public string Heading { get; set; }
        public string Action
        {
            get { return (Id != 0) ? "Update" : "Create"; }
        }
        public DateTime GetDateTime ()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
            
        }
    }

}