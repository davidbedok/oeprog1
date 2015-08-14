using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleMenu
{
    public class MenuItem
    {

        private readonly int id;
        private readonly String label;

        public int Id
        {
            get { return this.id; }
        }

        public String Label
        {
            get { return this.label; }
        }

        public int Length
        {
            get { return this.label.Length; }
        }

        public MenuItem(int id, String label)
        {
            this.id = id;
            this.label = label;
        }

    }
}
