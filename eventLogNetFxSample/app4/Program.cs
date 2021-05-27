using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lib;

namespace app4
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var user in EventLogHelper.GetEventUsers())
            {
                Console.WriteLine(user);
            }
        }
    }
}
