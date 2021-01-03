using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace console_net
{
    class Axe {
        public int Id { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string json = @"[3,4,7,1]";

            var list = JsonConvert.DeserializeObject<List<int>>(json);

            var Axes = new List<Axe>{ new Axe {Id = 1}, new Axe {Id = 2} };

            var r = Axes.Where(e => list.Contains(e.Id)).ToList();


            Console.WriteLine(JsonConvert.SerializeObject(r));
        }
    }
}
