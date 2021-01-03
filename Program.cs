using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace console_net
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var list = new AxeController().List();

            Console.WriteLine(JsonConvert.SerializeObject(list));

        }
    }

    class AxeController {
        protected List<Axe> Axes = new List<Axe>{ new Axe {Id = 1}, new Axe {Id = 2} };

        public List<Axe> List() {
            string json = @"[3,4,7,1]";

            string json2 = @"3";

            var list = Axes.Where(e => JsonArrayIntToListInt(json2).Contains(e.Id)).ToList();

            return list;

        }

        private List<int> JsonArrayIntToListInt(string jsonArrayOfInt) {

            if (!jsonArrayOfInt.Contains("["))
            {
                jsonArrayOfInt = $"[{jsonArrayOfInt}]";
            }

            return JsonConvert.DeserializeObject<List<int>>(jsonArrayOfInt);
        }
    }

    class Axe {
        public int Id { get; set; }
    }
}
