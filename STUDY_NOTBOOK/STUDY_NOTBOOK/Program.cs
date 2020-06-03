using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace STUDY_NOTBOOK
{

    class Program
    {
        static void Main(string[] args)
        {
            List<char> KeyList = new List<char>();
            ConsoleKeyInfo keyval = new ConsoleKeyInfo();
            
            do
            {
                keyval = Console.ReadKey();
                KeyList.Add(keyval.KeyChar);
            } while (keyval.Key != ConsoleKey.Q);
            {
                Console.WriteLine();
                foreach (var item in KeyList)
                {
                    Console.WriteLine(item);
                }
            }
                        
        }
    }
}
