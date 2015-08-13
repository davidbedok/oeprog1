using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StripLightAdvertising
{
    public class CharacterModel
    {

        private const char PIXEL = '#';

        private readonly bool[][] content;

        public int Width
        {
            get
            {
                return this.content[0].Length;
            }
        }

        public CharacterModel(char type)
            : this(CharacterTrunk.GetModelContent(type))
        {
        }

        private CharacterModel(bool[][] content)
        {
            this.content = content;
        }

        public override String ToString()
        {
            StringBuilder builder = new StringBuilder();
            for (int row = 0; row < content.Length; row++)
            {
                builder.AppendLine(this.GetRow(row));
            }
            return builder.ToString();
        }

        public String GetRow(int row)
        {
            StringBuilder builder = new StringBuilder();
            for (int column = 0; column < content[row].Length; column++)
            {
                builder.Append(content[row][column] ? PIXEL : ' ');
            }
            return builder.ToString();
        }

        public static CharacterModel BuildRandomModel(Random random, int minWidth, int maxWidth)
        {
            int width = random.Next(minWidth, maxWidth + 1);
            bool[][] content = new bool[CharacterData.HEIGHT][];
            for (int i = 0; i < CharacterData.HEIGHT; i++)
            {
                content[i] = new bool[width];
                for (int k = 0; k < width; k++)
                {
                    content[i][k] = random.Next(2) == 1;
                }
            }
            return new CharacterModel(content);
        }

    }
}
