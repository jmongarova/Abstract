using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3._1
{
    class XMLHandler:AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Open document XML");
        }
        public override void Create()
        {
            Console.WriteLine("Create document XML");
        }
        public override void Chenge()
        {
            Console.WriteLine("Chenge document XML");
        }
        public override void Save()
        {
            Console.WriteLine("Save document XML");
        }
    }
}
