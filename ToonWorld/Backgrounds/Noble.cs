﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToonWorld
{
    public class Noble : Background
    {
        public override List<string> Trait
        {
            get {
                return new List<string> {
            "My eloquent flattery makes everyone I talk to feel like the most wonderful and important person in the world.",
            "The common folk love me for my kindness and generosity.",
            "No one could doubt by looking at my regal bearing that I am a cut above the unwashed masses.",
            "I take great pains to always look my best and follow the latest fashions.",
            "I don’t like to get my hands dirty, and I won’t be caught dead in unsuitable accommodations..",
            "Despite my noble birth, I do not place myself above other folk. We all have the same blood.",
            "My favor, once lost, is lost forever.",
            "If you do me an injury, I will crush you, ruin your name, and salt your fields."};
            }
        }

        public override List<string> Ideal
        {
            get {
                return new List<string>{
            "Respect. Respect is due to me because of my position, but all people regardless of station deserve to be treated with dignity. (Good)",
            "Responsibility. It is my duty to respect the authority of those above me, just as those below me must respect mine. (Lawful)",
            "Independence. I must prove that I can handle myself without the coddling of my family. (Chaotic)",
            "Power. If I can attain more power, no one will tell me what to do. (Evil)",
            "Family. Blood runs thicker than water. (Any)",
            "Noble Obligation. It is my duty to protect and care for the people beneath me. (Good)"};
            }
        }

        public override List<string> Bond
        {
            get { return new List<string> {
            "I will face any challenge to win the approval of my family.",
            "My house’s alliance with another noble family must be sustained at all costs.",
            "Nothing is more important than the other members of my family.",
            "I am in love with the heir of a family that my family despises.",
            "My loyalty to my sovereign is unwavering.",
            "The common folk must see me as a hero o f the people."};
            }
        }

        public override List<string> Flaw
        {
            get { return new List<string>{
            "I secretly believe that everyone is beneath me.",
            "I hide a truly scandalous secret that could ruin my family forever.",
            "I too often hear veiled insults and threats in every word addressed to me, and I’m quick to anger.",
            "I have an insatiable desire for carnal pleasures.",
            "In fact, the world does revolve around me.",
            "By my words and actions, I often bring shame to my family." };
            }
        }

        public override Skills Skillz { get { return new Skills { History = 2, Persusion = 2 }; } } // 2 is prof bonus at lvl 1 
        public Tools Toolz { get { return new Tools { GamingSet = 1 }; } set {} }
        public List<string> Language { get { return new List<string> { "One Languages of your Choice" }; }} //make random?
        public override string ToString()
        {
            return "Noble";
        }
    }
}
