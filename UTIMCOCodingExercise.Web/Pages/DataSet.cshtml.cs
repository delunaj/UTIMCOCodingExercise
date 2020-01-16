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
    public class DataSetModel : PageModel
    {
        private readonly ILogger<DataSetModel> _logger;
        public JsonMenuService MenuService;
        public IEnumerable<RootObject> MenuCollection { get; private set; }

        public DataSetModel(ILogger<DataSetModel> logger, JsonMenuService menuService)
        {
            _logger = logger;
            MenuService = menuService;
        }

        public void OnGet() => MenuCollection = MenuService.GetMenus();
        
    }
}
