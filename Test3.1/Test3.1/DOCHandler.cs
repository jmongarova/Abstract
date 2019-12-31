using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3._1
{
    class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Open document DOC");
        }
        public override void Create()
        {
            Console.WriteLine("Create document DOC");
        }
        public override void Chenge()
        {
            Console.WriteLine("Chenge document DOC");
        }
        public override void Save()
        {
            Console.WriteLine("Save document DOC");
        }
    }
}
