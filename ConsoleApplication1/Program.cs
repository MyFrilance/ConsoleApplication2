using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++)
            {
                int h;
                int w;
                Console.WriteLine("print h");
                h = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("print w");
                w = Convert.ToInt32(Console.ReadLine());
                //объект создать здесь.
                Rectangle R1 = new Rectangle(h, w);
                R1.Area();
            }


            Console.ReadKey();
        }
    }

    class Rectangle
    {
        public int H;
        public int W;

        public Rectangle(int h, int w)
        {
            H = h;
            W = w;
        }

        public void Area()
        {
            int S = H * W;
            Console.WriteLine("Площадь" + S);
        }
    }

}
