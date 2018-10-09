﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToonWorld
{
    public struct Stats
    {
        public int Stregnth { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }

        public override string ToString()
        {
            return Stregnth.ToString() + ' ' +
                   Dexterity.ToString() + ' ' +
                   Constitution.ToString() + ' ' +
                   Intelligence.ToString() + ' ' +
                   Wisdom.ToString() + ' ' +
                   Charisma.ToString();
        }
    }

    public struct Skills
    {
        public int Acrobatics { get; set; }
        public int AnimalHandling { get; set; }
        public int Arcana { get; set; }
        public int Athletics { get; set; }
        public int Deception { get; set; }
        public int History { get; set; }
        public int Insight { get; set; }
        public int Intimidation { get; set; }
        public int Investigation { get; set; }
        public int Medicine { get; set; }
        public int Nature { get; set; }
        public int Perception { get; set; }
        public int Performance { get; set; }
        public int Persusion { get; set; }
        public int Religion { get; set; }
        public int SleightOfHand { get; set; }
        public int Stealth { get; set; }
        public int Survival { get; set; }

        public override string ToString()
        {
            return Acrobatics.ToString() + ' ' +
                   AnimalHandling.ToString() + ' ' +
                   Arcana.ToString() + ' ' +
                   Athletics.ToString() + ' ' +
                   Deception.ToString() + ' ' +
                   History.ToString() + ' ' +
                   Insight.ToString() + ' ' +
                   Intimidation.ToString() + ' ' +
                   Investigation.ToString() + ' ' +
                   Medicine.ToString() + ' ' +
                   Nature.ToString() + ' ' +
                   Perception.ToString() + ' ' +
                   Performance.ToString() + ' ' +
                   Persusion.ToString() + ' ' +
                   Religion.ToString() + ' ' +
                   SleightOfHand.ToString() + ' ' +
                   Stealth.ToString() + ' ' +
                   Survival.ToString();
        }
    }
        public struct Tools
        {
            public int ArtisansTools { get; set; }
            public int DisguiseKit { get; set; }
            public int ForgeryKit { get; set; }
            public int GamingSet { get; set; }
            public int HerbalismKit { get; set; }
            public int MusicalInstrument { get; set; }
            public int NavigatorsTools { get; set; }
            public int PoisonersKit { get; set; }
            public int ThievesTools { get; set; }

            public override string ToString()
            {
                return ArtisansTools.ToString() + ' ' +
                       DisguiseKit.ToString() + ' ' +
                       ForgeryKit.ToString() + ' ' +
                       GamingSet.ToString() + ' ' +
                       HerbalismKit.ToString() + ' ' +
                       MusicalInstrument.ToString() + ' ' +
                       NavigatorsTools.ToString() + ' ' +
                       PoisonersKit.ToString() + ' ' +
                       ThievesTools.ToString();
            }
        }

        public enum Lifestyles
        {
            Wretched,
            Squalid,
            Poor,
            Modest,
            Cofortable,
            Wealthy,
            Aristocratic
        }

        public enum Alignments
        {
            LawfulGood,
            LawfulNeutral,
            LawfulEvil,
            NeutralGood,
            TrueNeutral,
            NeutralEvil,
            ChaoticGood,
            ChaoticNeutral,
            ChaoticEvil
        }

        public enum Languages
        {
            Common,
            Dwarvish,
            Elvish,
            Giant,
            Gnomish,
            Goblin,
            Halfling,
            Orc,
            Abyssal,
            Celstial,
            Draconic,
            DeepSpeech,
            Infernal,
            Primordial,
            Sylvan,
            Undercommon
        }
    }
