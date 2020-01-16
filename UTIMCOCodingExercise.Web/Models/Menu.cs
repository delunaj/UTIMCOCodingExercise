using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UTIMCOCodingExercise.Models
{
    public class Menu
    {
        public string Header { get; set; }
        public List<Item> Items { get; set; }
    }
}
