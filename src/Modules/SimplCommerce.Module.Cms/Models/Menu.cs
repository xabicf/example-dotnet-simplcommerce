using SimplCommerce.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimplCommerce.Module.Cms.Models
{
    public class Menu : EntityBase
    {
        public virtual string Name {get;set;}
        public virtual bool IsDeleted { get; set; }
        public virtual bool IsMain { get; set; }
        public virtual IList<MenuItem> MenuItems { get; protected set; } = new List<MenuItem>();
    }
}
