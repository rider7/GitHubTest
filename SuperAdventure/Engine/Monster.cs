using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Monster : LivingCreature
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaximumDamage { get; set; }
        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }
        public List<LootItem> LootTable { get; set; }

        public Monster(int currenthp, int maximumhp, int id, string name, int maximumdamage, int rewardexperiencepoints, int rewardgold ) :
            base(currenthp, maximumhp)
        {
            ID = id;
            Name = name;
            MaximumDamage = maximumdamage;
            RewardExperiencePoints = rewardexperiencepoints;
            RewardGold = rewardgold;

            LootTable = new List<LootItem>();
        }
    }
}
