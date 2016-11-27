﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class LivingCreature
    {
        public int CurrentHP { get; set; }
        public int MaximumHP { get; set; }

        public LivingCreature(int currenthp, int maximumhp)
        {
            CurrentHP = currenthp;
            MaximumHP = maximumhp;
        }
    }
}
