﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToonWorld
{
    public class StoutHalfling : IRace
    {
        public int StrBonus { get { return 0; } }
        public int DexBonus { get { return 2; } }
        public int ConBonus { get { return 1; } }
        public int IntBonus { get { return 0; } }
        public int WisBonus { get { return 0; } }
        public int ChaBonus { get { return 0; } }
        public int AgeRange { get { return 300; } }
        public int Speed { get { return 25; } }
        public string Size { get { return "Small"; } }
        public string Language { get { return "Halfling, Common "; } }
        public override string ToString()
        {
            return "Stout Halfling";
        }
    }
}
