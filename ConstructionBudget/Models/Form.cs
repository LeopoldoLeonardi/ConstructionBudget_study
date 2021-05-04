using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructionBudget.Models
{
    public class Form
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public DateTime Date { get; set; }
        public string ZipCode { get; set; }
        public string StrAnddress { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public Form()
        {
        }

        public Form(int id, string projectName, DateTime date, string zipCode, string strAnddress, string city, string country, string name, string email)
        {
            Id = id;
            ProjectName = projectName;
            Date = date;
            ZipCode = zipCode;
            StrAnddress = strAnddress;
            City = city;
            Country = country;
            Name = name;
            Email = email;
        }
    }
}