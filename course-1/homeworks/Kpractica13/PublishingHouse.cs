using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpractica13
{
    public class PublishingHouse
    {
        public string Name { get; set; }

        public PublishingHouse(string name)
        {
            Name = name;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Издательство: {Name}");
        }
    }
}
