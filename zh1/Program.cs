using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zh1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch tw = new Stopwatch();
            tw.Start();
            while (tw.ElapsedMilliseconds < 100000) ;
            Debug.WriteLine(tw.ElapsedTicks.ToString());
            tw.Stop();
            
           

            Console.ReadKey();
        }
    }
}

