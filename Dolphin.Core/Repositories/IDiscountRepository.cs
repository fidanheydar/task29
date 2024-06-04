using Dolphin.Core.Entities;

namespace Dolphin.Core.Repositories
{
    public interface IDiscountRepository
    {
        IEnumerable<Discount> GetActiveDiscounts();
        Discount GetDiscountById(int discountId);
    }
}
