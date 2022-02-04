using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace organisationnewportal.Models
{
    public class User
    {
        public int Id{get;set;}
        public string Name{get; set;}
        public string Role{get;set;}
        public string Position {get;set;}
        public int DepartmentId {get; set;}


    }
}