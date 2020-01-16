using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UTIMCOCodingExercise.Models;
using UTIMCOCodingExercise.Services;

namespace UTIMCOCodingExercise.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MenusController : ControllerBase
    {
        public MenusController(JsonMenuService menuService)
        {
            this.MenuService = menuService;
        }

        public JsonMenuService MenuService { get; }

        [HttpGet]
        public IEnumerable<RootObject> Get()
        {
            return MenuService.GetMenus();
        }
    }
}