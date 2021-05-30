using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingProject
{
    public class Better:Runner
    {
        public int chkValue(int y) {
            if (y < 0)
            {
                return 0;
            }
            else {
                return 1;
            }
        }

        // winner result function

        public int winnerResult(int bet,int winner,int rabit,int budget) {
            if (winner == rabit)
            {
                return budget + bet;
            }
            else {
                return budget - bet;
            }

        }
    }
}
