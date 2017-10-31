using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    class Directory
    {
        public static string Basedirectory()
        {
            string based = AppDomain.CurrentDomain.BaseDirectory; 
            return based;
        }

            
    }
}
