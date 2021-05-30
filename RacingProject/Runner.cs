using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingProject
{
   public class Runner
    {
        Random instance = new Random();
        public int jumpRabit() {
            return instance.Next(1, 50);
        }


    }
}
