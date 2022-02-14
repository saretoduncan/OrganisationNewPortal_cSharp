using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace organisationnewportal.Models
{
    public class DepartmentNews
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public int UserId { get; set; }
        public string NewsHeading { get; set; }
        public string News { get; set; }








    }
}