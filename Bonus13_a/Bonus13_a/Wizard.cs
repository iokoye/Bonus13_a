using System;
using System.Collections.Generic;
using System.Text;

namespace Bonus13_a
{
    public class Wizard : MagicUsingCharacter
    {
        public int SpellNumber { get; set; }

        public Wizard(string name, int strength, int intelligence, int magicalEnergy, int spellNumber) : base(name, strength, intelligence, magicalEnergy)
        {
            SpellNumber = spellNumber;
        }

        public override string Play()
        {

            return $" Character name is: {Name}, Strength: {Strength}, Intelligence: {Intelligence}, Magic Energy: {MagicalEnergy}, Spell Number: {SpellNumber}";

        }
    }
}
