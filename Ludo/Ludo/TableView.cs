using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo
{
    public class TableView
    {

        public const char FIELD = 'F';
        public const char START = 'S';
        public const char DESTINATION = 'D';

        public static readonly char[][] TYPE = { //
	//
			new char[]{ 'S', ' ', 'S', ' ', 'F', 'F', 'F', ' ', 'S', ' ', 'S' }, //
			new char[]{ ' ', ' ', ' ', ' ', 'F', 'D', 'F', ' ', ' ', ' ', ' ' }, //
			new char[]{ 'S', ' ', 'S', ' ', 'F', 'D', 'F', ' ', 'S', ' ', 'S' }, //
			new char[]{ ' ', ' ', ' ', ' ', 'F', 'D', 'F', ' ', ' ', ' ', ' ' }, //
			new char[]{ 'F', 'F', 'F', 'F', 'F', 'D', 'F', 'F', 'F', 'F', 'F' }, //
			new char[]{ 'F', 'D', 'D', 'D', 'D', ' ', 'D', 'D', 'D', 'D', 'F' }, //
			new char[]{ 'F', 'F', 'F', 'F', 'F', 'D', 'F', 'F', 'F', 'F', 'F' }, //
			new char[]{ ' ', ' ', ' ', ' ', 'F', 'D', 'F', ' ', ' ', ' ', ' ' }, //
			new char[]{ 'S', ' ', 'S', ' ', 'F', 'D', 'F', ' ', 'S', ' ', 'S' }, //
			new char[]{ ' ', ' ', ' ', ' ', 'F', 'D', 'F', ' ', ' ', ' ', ' ' }, //
			new char[]{ 'S', ' ', 'S', ' ', 'F', 'F', 'F', ' ', 'S', ' ', 'S' }, //
	};

        public static readonly int[][] OWNER = { //
	//
			new int[]{ 1, 0, 1, 0, 0, 0, 0, 0, 4, 0, 4 }, //
			new int[]{ 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 }, //
			new int[]{ 1, 0, 1, 0, 0, 1, 0, 0, 4, 0, 4 }, //
			new int[]{ 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 }, //
			new int[]{ 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 }, //
			new int[]{ 0, 2, 2, 2, 2, 0, 4, 4, 4, 4, 0 }, //
			new int[]{ 0, 0, 0, 0, 0, 3, 0, 0, 0, 0, 0 }, //
			new int[]{ 0, 0, 0, 0, 0, 3, 0, 0, 0, 0, 0 }, //
			new int[]{ 2, 0, 2, 0, 0, 3, 0, 0, 3, 0, 3 }, //
			new int[]{ 0, 0, 0, 0, 0, 3, 0, 0, 0, 0, 0 }, //
			new int[]{ 2, 0, 2, 0, 0, 0, 0, 0, 3, 0, 3 } //
	};

        public static readonly int[][] INDEX = { //
	//
			new int[]{ 0, -1, 1, -1, 0, 39, 38, -1, 1, -1, 0 }, //
			new int[]{ -1, -1, -1, -1, 1, 3, 37, -1, -1, -1, -1 }, //
			new int[]{ 2, -1, 3, -1, 2, 2, 36, -1, 3, -1, 2 }, //
			new int[]{ -1, -1, -1, -1, 3, 1, 35, -1, -1, -1, -1 }, //
			new int[]{ 8, 7, 6, 5, 4, 0, 34, 33, 32, 31, 30 }, //
			new int[]{ 9, 3, 2, 1, 0, -1, 0, 1, 2, 3, 29 }, //
			new int[]{ 10, 11, 12, 13, 14, 0, 24, 25, 26, 27, 28 }, //
			new int[]{ -1, -1, -1, -1, 15, 1, 23, -1, -1, -1, -1 }, //
			new int[]{ 2, -1, 3, -1, 16, 2, 22, -1, 3, -1, 2 }, //
			new int[]{ -1, -1, -1, -1, 17, 3, 21, -1, -1, -1, -1 }, //
			new int[]{ 0, -1, 1, -1, 18, 19, 20, -1, 1, -1, 0 }, //
	};

    }
}
