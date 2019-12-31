using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3._2
{
    class Player:IPlayable,IRecordable
    {
        public void Play()
        { Console.WriteLine("Проигрывется видео"); }
        public void Pause()
        { Console.WriteLine("Видео приостановлено"); }
        public void Stop()
        { Console.WriteLine("Видео остановлено"); }
        public void Record()
        { Console.WriteLine("Идет запись видео"); }
    }
}
