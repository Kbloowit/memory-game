using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memorie
{
    class Directory
    {

        #region properties
        /// <summary>
        /// holds the base path;
        /// </summary>
        public static string BasePath { get; private set; }

        #endregion

        #region constructor
        /// <summary>
        /// starts the constructor;
        /// </summary>
        public Directory()
        {
            BasePath = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.FullName;
        }
        #endregion

        #region get methods
        /// <summary>
        /// get base path
        /// </summary>
        /// <returns>Return the base path</returns>
        public static string GetBasePath()
        {
            return BasePath;
        }

        #endregion






    }
}
