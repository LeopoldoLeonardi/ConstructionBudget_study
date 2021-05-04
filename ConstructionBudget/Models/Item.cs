using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructionBudget.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Unity { get; set; }
        public double Amount { get; set; }
        public double Value { get; set; }
        public double Subtotal { get; set; }
        public double TotalValue { get; set; }

        public Item()
        {
        }

        public Item(int id, string description, string unity, double amount, double value, double subtotal, double totalValue)
        {
            Id = id;
            Description = description;
            Unity = unity;
            Amount = amount;
            Value = value;
            Subtotal = subtotal;
            TotalValue = totalValue;
        }
    }
}
