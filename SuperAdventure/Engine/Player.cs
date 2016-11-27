using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player : LivingCreature
    {
        public int Gold { get; set; }
        public int ExperiencePoints { get; set; }
        public int Level { get; set; }

        public Player(int currenthp, int maximumhp, int gold, int experiencepoints, int level) :
            base(currenthp, maximumhp)
        {
            Gold = gold;
            ExperiencePoints = experiencepoints;
            Level = level;
        }
    }
}
