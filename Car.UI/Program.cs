using Cars.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            var b = context.Manufacturers.ToList();
            foreach (var item in b)
            { Console.WriteLine("Manufacturer {0}, {1}, {2}", item.id, item.Name, item.Country);
            }           ; Console.ReadKey();
        }
    }
}
