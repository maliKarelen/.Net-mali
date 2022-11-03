using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_GUI
{
    class Program
    {
        static void Main(string[] args)
        {

            var listMock = BLL.Utilities.ConfigEmailDependencies("Mock").GetAll();

            foreach (var item in listMock)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
