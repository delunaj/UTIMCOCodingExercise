using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using UTIMCOCodingExercise.Models;

namespace UTIMCOCodingExercise.Services
{
    //Service to return deserialized IEnumerable of Menus from json file
    //This service serves to decouple accessing the data source so that future development isn't tightly dependent on the data source should it change
    public class JsonMenuService
    {
        //constructor - accepts host environment (to get path for menu file)
        public JsonMenuService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        //property - to keep environment
        public IWebHostEnvironment WebHostEnvironment { get; }

        //property - returns path to menu
        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "samplemenu.json"); }
        }

        //method to retrieve menus of items from file; returns IEnumerable of RootObject
        public IEnumerable<RootObject> GetMenus()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<RootObject[]>(jsonFileReader.ReadToEnd(), 
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }
    }
}
