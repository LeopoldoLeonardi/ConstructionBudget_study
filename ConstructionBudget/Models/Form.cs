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

    }
}