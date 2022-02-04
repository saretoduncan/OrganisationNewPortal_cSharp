using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace organisationnewportal.Models
{
    public class GeneralNews
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public string NewsHeading { get; set; }
        public string News { get; set; }
    }
}