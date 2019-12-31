using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3._1
{
    class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Open document TXT");
        }
        public override void Create()
        {
            Console.WriteLine("Create document TXT");
        }
        public override void Chenge()
        {
            Console.WriteLine("Chenge document TXT");
        }
        public override void Save()
        {
            Console.WriteLine("Save document TXT");
        }
    }
}
