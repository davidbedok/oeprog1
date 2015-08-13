using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StripLightAdvertising
{
    public class CharacterTrunk
    {

        private static readonly CharacterData[] CHARACTERS = new CharacterData[]{ 
            CharacterData.A_MODEL, 
            CharacterData.B_MODEL, 
            CharacterData.C_MODEL, 
            CharacterData.D_MODEL, 
            CharacterData.O_MODEL, 
            CharacterData.I_MODEL, 
            CharacterData.U_MODEL,
            CharacterData.E_MODEL, 
            CharacterData.G_MODEL,
            CharacterData.M_MODEL,
            CharacterData.SPACE_MODEL,
            CharacterData.T_MODEL,
            CharacterData.Y_MODEL};

        public static bool[][] GetModelContent(char letter)
        {
            bool find = false;
            int i = 0;
            while (i < CHARACTERS.Length && !find)
            {
                find = (CHARACTERS[i].Letter == letter);
                i++;
            }
            return CHARACTERS[i - 1].Model;
        }

    }
}
