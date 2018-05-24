using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program

    {
        static void Main(string[] args)
        {
            var x = new db();
            var a = x.autos.Where(i => i.marca == "Ford").ToList();



        }
    }
}
