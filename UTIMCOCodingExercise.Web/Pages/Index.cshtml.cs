using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using UTIMCOCodingExercise.Models;
using UTIMCOCodingExercise.Services;

namespace UTIMCOCodingExercise.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonMenuService MenuService;
        public IEnumerable<RootObject> MenuCollection { get; private set; }

        //constructor - accepts JsonMenuService param to decouple data source access
        public IndexModel(ILogger<IndexModel> logger, JsonMenuService menuService)
        {
            _logger = logger;
            MenuService = menuService;
        }

        public void OnGet() => MenuCollection = MenuService.GetMenus();

    }
}
