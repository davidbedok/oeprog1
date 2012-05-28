using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StripLightAdvertising
{
    public class CharacterModel
    {

        private byte[][] model;

        public CharacterModel( char type, Random rand )
        {
            if (type == 'R')
            {
                this.model = new byte[CharacterData.CHAR_HEIGHT][];
                for (int i = 0; i < CharacterData.CHAR_HEIGHT; i++)
                {
                    this.model[i] = new byte[CharacterData.CHAR_WIDTH];
                    for (int j = 0; j < CharacterData.CHAR_WIDTH; j++)
                    {
                        this.model[i][j] = (byte)(rand.Next(2));
                    }
                }
            }
            else
            {
                this.model = CharacterTrunk.getCharacterModel(type);
            }
        }

        public string getRow(int index)
        {
            StringBuilder sb = new StringBuilder();
            for (int j = 0; j < model[index].Length; j++)
            {
                sb.Append(model[index][j] == 1 ? "#" : " ");
            }
            return sb.ToString();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < model.Length; i++){
                for (int j = 0; j < model[i].Length; j++){
                    sb.Append( model[i][j] == 1 ? "#" : " ");
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }

    }
}
