using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UTIMCOCodingExercise.Models
{
    public class RootObject 
    {
        [JsonProperty("menu")]
        public Menu Menu { get; set; }
    }
}
