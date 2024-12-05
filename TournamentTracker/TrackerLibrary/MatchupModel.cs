using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        public List<MatchUpEntryModel> Entries { get; set; } = new List<MatchUpEntryModel> ();
        public TeamModel Winner { get; set; }
        public int MatchupRound { get; set; }
    }
}
