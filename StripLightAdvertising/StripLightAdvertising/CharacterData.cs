﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StripLightAdvertising
{
    public class CharacterData
    {

        public const byte HEIGHT = 7;

        public static readonly CharacterData A_MODEL = new CharacterData('A', new byte[][]{
                                                     new byte[]{ 0, 0, 1, 0, 0 }, 
                                                     new byte[]{ 0, 1, 0, 1, 0 },
                                                     new byte[]{ 0, 1, 0, 1, 0 },
                                                     new byte[]{ 0, 1, 1, 1, 0 },
                                                     new byte[]{ 1, 0, 0, 0, 1 },
                                                     new byte[]{ 1, 0, 0, 0, 1 },
                                                     new byte[]{ 1, 0, 0, 0, 1 } });

        public static readonly CharacterData B_MODEL = new CharacterData('B', new byte[][]{ 
                                                     new byte[]{ 1, 1, 1, 1, 0 }, 
                                                     new byte[]{ 1, 0, 0, 0, 1 },
                                                     new byte[]{ 1, 0, 0, 0, 1 },
                                                     new byte[]{ 1, 1, 1, 1, 0 },
                                                     new byte[]{ 1, 0, 0, 0, 1 },
                                                     new byte[]{ 1, 0, 0, 0, 1 },
                                                     new byte[]{ 1, 1, 1, 1, 0 } });

        public static readonly CharacterData C_MODEL = new CharacterData('C', new byte[][]{ 
                                                     new byte[]{ 0, 0, 1, 1, 0 }, 
                                                     new byte[]{ 0, 1, 0, 0, 1 },
                                                     new byte[]{ 1, 0, 0, 0, 0 },
                                                     new byte[]{ 1, 0, 0, 0, 0 },
                                                     new byte[]{ 1, 0, 0, 0, 0 },
                                                     new byte[]{ 0, 1, 0, 0, 1 },
                                                     new byte[]{ 0, 0, 1, 1, 0 } });

        public static readonly CharacterData O_MODEL = new CharacterData('O', new byte[][]{ 
                                                     new byte[]{ 0, 1, 1, 1, 0 }, 
                                                     new byte[]{ 1, 0, 0, 0, 1 },
                                                     new byte[]{ 1, 0, 0, 0, 1 },
                                                     new byte[]{ 1, 0, 0, 0, 1 },
                                                     new byte[]{ 1, 0, 0, 0, 1 },
                                                     new byte[]{ 1, 0, 0, 0, 1 },
                                                     new byte[]{ 0, 1, 1, 1, 0 } });

        public static readonly CharacterData U_MODEL = new CharacterData('U', new byte[][]{ 
                                                     new byte[]{ 1, 0, 0, 0, 1 }, 
                                                     new byte[]{ 1, 0, 0, 0, 1 },
                                                     new byte[]{ 1, 0, 0, 0, 1 },
                                                     new byte[]{ 1, 0, 0, 0, 1 },
                                                     new byte[]{ 1, 0, 0, 0, 1 },
                                                     new byte[]{ 1, 0, 0, 0, 1 },
                                                     new byte[]{ 0, 1, 1, 1, 0 } });

        public static readonly CharacterData D_MODEL = new CharacterData('D', new byte[][]{ 
                                                     new byte[]{ 1, 1, 1, 0, 0 }, 
                                                     new byte[]{ 1, 0, 0, 1, 0 },
                                                     new byte[]{ 1, 0, 0, 0, 1 },
                                                     new byte[]{ 1, 0, 0, 0, 1 },
                                                     new byte[]{ 1, 0, 0, 0, 1 },
                                                     new byte[]{ 1, 0, 0, 1, 0 },
                                                     new byte[]{ 1, 1, 1, 0, 0 } });

        public static readonly CharacterData I_MODEL = new CharacterData('I', new byte[][]{ 
                                                     new byte[]{ 0, 1, 0 }, 
                                                     new byte[]{ 0, 1, 0 },
                                                     new byte[]{ 0, 1, 0 },
                                                     new byte[]{ 0, 1, 0 },
                                                     new byte[]{ 0, 1, 0 },
                                                     new byte[]{ 0, 1, 0 },
                                                     new byte[]{ 0, 1, 0 } });

        public static readonly CharacterData SPACE_MODEL = new CharacterData(' ', new byte[][]{ 
                                                     new byte[]{ 0, 0, 0 }, 
                                                     new byte[]{ 0, 0, 0 },
                                                     new byte[]{ 0, 0, 0 },
                                                     new byte[]{ 0, 0, 0 },
                                                     new byte[]{ 0, 0, 0 },
                                                     new byte[]{ 0, 0, 0 },
                                                     new byte[]{ 0, 0, 0 } });

        public static readonly CharacterData E_MODEL = new CharacterData('E', new byte[][]{ 
                                                     new byte[]{ 1, 1, 1, 1, 1 }, 
                                                     new byte[]{ 1, 0, 0, 0, 0 },
                                                     new byte[]{ 1, 0, 0, 0, 0 },
                                                     new byte[]{ 1, 1, 1, 0, 0 },
                                                     new byte[]{ 1, 0, 0, 0, 0 },
                                                     new byte[]{ 1, 0, 0, 0, 0 },
                                                     new byte[]{ 1, 1, 1, 1, 1 } });

        public static readonly CharacterData G_MODEL = new CharacterData('G', new byte[][]{ 
                                                     new byte[]{ 0, 1, 1, 1, 0 }, 
                                                     new byte[]{ 1, 0, 0, 0, 1 },
                                                     new byte[]{ 1, 0, 0, 0, 0 },
                                                     new byte[]{ 1, 0, 0, 1, 1 },
                                                     new byte[]{ 1, 0, 0, 0, 1 },
                                                     new byte[]{ 1, 0, 0, 0, 1 },
                                                     new byte[]{ 0, 1, 1, 1, 0 } });

        public static readonly CharacterData Y_MODEL = new CharacterData('Y', new byte[][]{ 
                                                     new byte[]{ 1, 0, 0, 0, 1 }, 
                                                     new byte[]{ 1, 0, 0, 0, 1 },
                                                     new byte[]{ 1, 0, 0, 0, 1 },
                                                     new byte[]{ 0, 1, 0, 1, 0 },
                                                     new byte[]{ 0, 0, 1, 0, 0 },
                                                     new byte[]{ 0, 0, 1, 0, 0 },
                                                     new byte[]{ 0, 0, 1, 0, 0 } });

        public static readonly CharacterData T_MODEL = new CharacterData('T', new byte[][]{ 
                                                     new byte[]{ 1, 1, 1, 1, 1 }, 
                                                     new byte[]{ 0, 0, 1, 0, 0 },
                                                     new byte[]{ 0, 0, 1, 0, 0 },
                                                     new byte[]{ 0, 0, 1, 0, 0 },
                                                     new byte[]{ 0, 0, 1, 0, 0 },
                                                     new byte[]{ 0, 0, 1, 0, 0 },
                                                     new byte[]{ 0, 0, 1, 0, 0 } });

        public static readonly CharacterData M_MODEL = new CharacterData('M', new byte[][]{ 
                                                     new byte[]{ 1, 0, 0, 0, 0, 0, 1 }, 
                                                     new byte[]{ 1, 1, 0, 0, 0, 1, 1 },
                                                     new byte[]{ 1, 0, 1, 0, 1, 0, 1 },
                                                     new byte[]{ 1, 0, 0, 1, 0, 0, 1 },
                                                     new byte[]{ 1, 0, 0, 0, 0, 0, 1 },
                                                     new byte[]{ 1, 0, 0, 0, 0, 0, 1 },
                                                     new byte[]{ 1, 0, 0, 0, 0, 0, 1 } });

        private readonly byte[][] data;
        private readonly char letter;

        public bool[][] Model
        {
            get
            {
                bool[][] result = new bool[this.data.Length][];
                for (int i = 0; i < this.data.Length; i++)
                {
                    result[i] = new bool[this.data[i].Length];
                    for (int k = 0; k < this.data[i].Length; k++)
                    {
                        result[i][k] = this.data[i][k] == 1;
                    }
                }
                return result;
            }
        }

        public char Letter
        {
            get { return this.letter; }
        }

        private CharacterData(char letter, byte[][] data)
        {
            this.letter = letter;
            this.data = data;
        }

    }
}
