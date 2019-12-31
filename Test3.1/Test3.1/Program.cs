using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Test3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractHandler handler; 
            string str;
            Console.WriteLine("Enter your str");
            str = Console.ReadLine();
            Regex myRegXML = new Regex(".xml|.XML"); // создание регулярного выражения
            Regex myRegTXT = new Regex(".txt|.TXT");
            Regex myRegDOC = new Regex(".doc|.DOC");
            if (myRegXML.IsMatch(str))
            {
                handler = new XMLHandler();
            }
            else if (myRegTXT.IsMatch(str))
            {
                handler = new TXTHandler();
            }
            else if (myRegDOC.IsMatch(str))
            {
                handler = new DOCHandler();
            }
            else
            {
                handler = null;
            }
            if (handler != null)
            {
                handler.Open();
                handler.Create();
                handler.Chenge();
                handler.Save();
            }
            else
            {
                Console.WriteLine("Sorry, but...");
            }
            Console.ReadKey();
        }
    }
}
