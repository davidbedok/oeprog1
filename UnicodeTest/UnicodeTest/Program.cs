using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnicodeTest
{
    public class Program
    {

        private readonly String value;

        private void testUnicode(bool \u0066)
        {
            char c = '\u0066';
            if (\u0066)
            {
                System.Console.WriteLine(c.ToString());
            }
        }

        private void test(bool f)
        {
            char c = 'f';
            if (f)
            {
                System.Console.WriteLine(c.ToString());
            }
        }     

	    public Program() {
            this.test(true);
            this.testUnicode(true);
	    }

        static void Main(string[] args)
        {
            new Program();
        }
    }
}
