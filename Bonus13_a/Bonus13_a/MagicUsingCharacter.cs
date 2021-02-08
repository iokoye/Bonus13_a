using System;
using System.Collections.Generic;
using System.Text;

namespace Bonus13_a
{
    public class MagicUsingCharacter : GameCharacter
    {
        public int MagicalEnergy { get; set; }
        public MagicUsingCharacter(string name, int strength, int intelligence, int magicalEnergy) : base(name, strength, intelligence)
        {
            MagicalEnergy = magicalEnergy;
        }

        public override string Play()
        {

            return $" Character name is: {Name}, Strength: {Strength}, Intelligence: {Intelligence}, Magic Energy: {MagicalEnergy}";

        }
    }
}
