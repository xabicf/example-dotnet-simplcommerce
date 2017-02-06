using SimplCommerce.Infrastructure.Models;
using SimplCommerce.Module.Core.Models;

namespace SimplCommerce.Module.Cms.Models
{
    public class MenuItem : EntityBase
    {
        public virtual bool IsDeleted { get; set; }
        public virtual long? ParentId { get; set; }
        public virtual MenuItem Parent { get; set; }
        public virtual long MenuId { get; set; }
        public virtual Menu Menu { get; set; }
        public virtual long? EntityId { get; set; }
        public virtual Entity Entity { get; set; }
    }
}
