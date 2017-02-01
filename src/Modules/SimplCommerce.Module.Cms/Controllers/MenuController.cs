using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SimplCommerce.Infrastructure.Data;
using SimplCommerce.Module.Catalog.Models;
using SimplCommerce.Module.Cms.Models;
using SimplCommerce.Module.Cms.Services;
using System.Linq;

namespace SimplCommerce.Module.Cms.Controllers
{
    [Authorize(Roles = "admin")]
    [Route("api/menu")]
    public class MenuController : Controller
    {
        private IRepository<Category> _categoryRepository;
        private IRepository<Page> _pageRepository;
        public MenuController(IRepository<Category> categoryRepository, IRepository<Page> pageRepository)
        {
            this._categoryRepository = categoryRepository;
            this._pageRepository = pageRepository;
        }
        [HttpGet()]
        public JsonResult Get()
        {
            var result = new
            {
                Categories = _categoryRepository.Query().Where(x=>!x.IsDeleted).Select(x=>new CategoryMenuItem { Id = x.Id,Name=x.Name}),
                Pages = _pageRepository.Query().Where(x => !x.IsDeleted).Select(x => new PageMenuItem { Id = x.Id, Name = x.Name }),
            };
            return Json(result);
        }
    }
}
