using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketGame
{
    public class Cricket
    {
        public int PlayerScore { get; set; }

        private int _flag=0;

        public Cricket()
        {
            PlayerScore = 0;
          
        }
        public void Score(int runs)
        {
            if (runs >= 7 || runs <= 0)
            {
                PlayerScore = 0;
            }
            else { 
                if(_flag==0)
                   this.PlayerScore += runs;
            }
        }
        public void GetOut()
        {
            _flag = 1;
        }


    }
}
