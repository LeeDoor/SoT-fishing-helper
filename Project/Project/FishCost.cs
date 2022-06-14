using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sea_of_Thieves_helper
{
    public struct FishCost
    {
        public int Regular;
        public int Trophy;

        public FishCost(int reguar, int trophy)
        {
            Regular = reguar;
            Trophy = trophy;
        }
    }
}
