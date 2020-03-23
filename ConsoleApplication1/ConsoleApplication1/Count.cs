using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Count
    {
        public string Name { get; set; }
        public int Num { get; set; }
        public double Sum { get; set; }
        public void add()
        {
            Name = Console.ReadLine();
            Num = Convert.ToInt32(Console.ReadLine());
            Sum = Convert.ToDouble(Console.ReadLine());
        }
        public void watch()
        {
            Console.Write(" " + Name);
            Console.Write(" " + Num);
            Console.Write(" " + Sum);
        }
    }
}
