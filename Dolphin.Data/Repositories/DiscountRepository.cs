using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolphin.Data.Repositories
{
    public class DiscountRepository : IDiscountRepository
    {
        private readonly DolphinDbContext _context;

        public DiscountRepository(DolphinDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Discount> GetActiveDiscounts()
        {
            return _context.Discounts.Where(d => d.IsActive && d.StartDate <= DateTime.Now && d.EndDate >= DateTime.Now).ToList();
        }

        public Discount GetDiscountById(int discountId)
        {
            return _context.Discounts.FirstOrDefault(d => d.DiscountId == discountId);
        }
    }
}
