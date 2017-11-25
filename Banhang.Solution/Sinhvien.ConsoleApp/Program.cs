using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinhvien.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var cmd = new Banhang.Repository.SinhvienListRepository())
            {
                foreach (Banhang.Domain.Sinhvien item in cmd.Execute())
                {
                    Console.WriteLine(item.Maso);
                }
            }
            Console.ReadLine();
        }
    }
}
