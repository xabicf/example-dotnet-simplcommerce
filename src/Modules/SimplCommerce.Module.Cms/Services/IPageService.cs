using SimplCommerce.Module.Cms.Models;
using System.Collections.Generic;

namespace SimplCommerce.Module.Cms.Services
{
    public interface IPageService
    {
        void Create(Page page);

        void Update(Page page);

        void Delete(Page page);

        List<Page> GetAll();
    }
}
