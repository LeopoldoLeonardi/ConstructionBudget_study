using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ConstructionBudget.Models;

namespace ConstructionBudget.Models
{
    public class ConstructionBudgetContext : DbContext
    {
        public ConstructionBudgetContext (DbContextOptions<ConstructionBudgetContext> options)
            : base(options)
        {
        }

        public DbSet<ConstructionBudget.Models.Form> Form { get; set; }

        public DbSet<ConstructionBudget.Models.Item> Item { get; set; }
    }
}
