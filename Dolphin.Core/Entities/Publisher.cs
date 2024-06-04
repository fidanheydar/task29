using Dolphin.Core.Entities.BaseEntities;

namespace Dolphin.Core.Entities
{
    public class Publisher : BaseEntity
    {
        
        public string Name { get; set; }
        public List<Book>? Books { get; set; }
    }
}
