using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SimplCommerce.Infrastructure.Data;
using SimplCommerce.Module.Catalog.Models;
using SimplCommerce.Module.Cms.Models;
using SimplCommerce.Module.Cms.ViewModels;
using SimplCommerce.Module.Core.Models;
using System.Linq;

namespace SimplCommerce.Module.Cms.Controllers
{
    [Authorize(Roles = "admin")]
    [Route("api/menu")]
    public class MenuController : Controller
    {
        private IRepository<Category> _categoryRepository;
        private IRepository<Page> _pageRepository;
        private IRepository<Brand> _brandRepository;
        private IRepository<Entity> _entityRepository;
        private IRepository<EntityType> _entityTypeRepository;
        public MenuController(IRepository<Category> categoryRepository, 
            IRepository<Page> pageRepository,
            IRepository<Brand> brandRepository,
            IRepository<Entity> entityRepository,
            IRepository<EntityType> entityTypeRepository)
        {
            this._categoryRepository = categoryRepository;
            this._pageRepository = pageRepository;
            this._brandRepository = brandRepository;
            this._entityRepository = entityRepository;
            this._entityTypeRepository = entityTypeRepository;
        }
        [HttpGet()]
        public IActionResult Get()
        {
            var entities = from e in _entityRepository.Query()
                      join et in _entityTypeRepository.Query() on e.EntityTypeId equals et.Id
                      where (e.EntityTypeId == (int)EntityTypes.Brand 
                      || e.EntityTypeId == (int)EntityTypes.Page 
                      || e.EntityTypeId == (int)EntityTypes.Category)
                      select new { Id = e.Id, EntityTypeId = e.EntityTypeId, Type = et.Name };
            var groupedEntities = (entities.GroupBy(x => x.Type, p => new { Id = p.Id, Type = p.Type },
                (key, g) => new
                {
                    Key = key,
                    Entities = g.ToList()
                })).ToList();
            return Json(groupedEntities);
        }
    }
}
