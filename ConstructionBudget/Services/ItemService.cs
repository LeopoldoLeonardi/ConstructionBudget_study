using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ConstructionBudget.Models;


namespace ConstructionBudget.Services
{
    public class ItemService
    {
        private readonly ConstructionBudgetContext _context;

        public ItemService(ConstructionBudgetContext context)
        {
            _context = context;
        }

        public async Task<List<IGrouping<Form, Item>>> FindByDateGroupingAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.Form select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate.Value);
            }
            return await result
                .Include(x => x.Item)
                .Include(x => x.Item.Form)
                .OrderByDescending(x => x.Date)
                .GroupBy(x => x.Item.Form)
                .ToListAsync();
        }
    }
}
