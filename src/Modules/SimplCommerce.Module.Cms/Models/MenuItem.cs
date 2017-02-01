using SimplCommerce.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimplCommerce.Module.Cms.Models
{
    public class MenuItem : EntityBase
    {
        public virtual bool IsDeleted { get; set; }
        public virtual long? ParentId { get; set; }
        public virtual MenuItem Parent { get; set; }
    }
}
