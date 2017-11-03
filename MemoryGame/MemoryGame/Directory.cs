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
        #region Basedirectory
        /// <summary>
        /// Geeft aan waar de applicatie staat
        /// </summary>
        /// <returns>
        /// opstartpad applicatie
        /// </returns>
        public static string Basedirectory()
        {
            string based = AppDomain.CurrentDomain.BaseDirectory; 
            return based;
        }
       #endregion


    }
}
