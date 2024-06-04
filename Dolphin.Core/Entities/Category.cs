using Dolphin.Core.Entities.BaseEntities;

namespace Dolphin.Core.Entities
{
	public class Category : BaseEntity
	{
		public string Name { get; set; }
        public List<BookCategory>? BookCategories { get; set; }
		public List<ToyCategory>? ToyCategories { get; set; }

    }
}

