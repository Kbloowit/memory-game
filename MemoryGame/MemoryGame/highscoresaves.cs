using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{

    [Serializable()]

    public class highscoresaves
    {
        public int Score { get; set; }
        public string Initials { get; set; }

        public List<highscoresaves> highscorelist = new List<highscoresaves>();

        


    }








}
