using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Player video = new Player();
            video.Play();
            video.Pause();
            video.Stop();
            video.Record();
            Console.ReadKey();
        }
    }
}
