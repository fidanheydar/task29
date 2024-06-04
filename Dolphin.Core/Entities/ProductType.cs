using Dolphin.Core.Entities.BaseEntities;

namespace Dolphin.Core.Entities
{
    public class ProductType:BaseEntity
    {
        public string Type { get; set; }
		public List<Book>? Books { get; set; }
		public List<Toy>? Toys { get; set; }

    }
}
