using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchUpEntryModel
    {
        /// <summary>
        /// Represent one team in the matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// Represnts score for this particural team
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        ///  Represent the matchup that this team from from
        ///  as the winner.
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
