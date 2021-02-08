using System;
using System.Collections.Generic;

namespace Bonus13_a
{
    class Program
    {
        static void Main(string[] args)
        {            
            GameCharacter gogeta = new Warrior("Gogeta", 9001, 1, "Kameha Wave");
            GameCharacter maxi = new Warrior("Maxi", 48, 9, "Nunchaku");
            GameCharacter harry = new Wizard("Harry", 6, 78, 6, 7 );
            GameCharacter hermoine = new Wizard("Hermione", 96, 74, 86, 57);
            GameCharacter ron = new Wizard("Ron", 46, 70, 61, 37);

            GameCharacter[] gameCharacters = new GameCharacter[] { gogeta, maxi, harry, hermoine, ron };

            for (int i = 0; i < gameCharacters.Length; i++)
            {
                Console.WriteLine(gameCharacters[i].Play());
            }
           
        }
    }
}
