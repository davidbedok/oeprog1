using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleMenu
{
    public class MenuTemplate
    {

        public static readonly MenuTemplate DEFAULT_TEMPLATE = new MenuTemplate(MenuColor.DEFAULT_NORMAL, MenuColor.DEFAULT_HIGHLIGHTED);

        private readonly MenuColor normal;
        private readonly MenuColor highlighted;

        public MenuColor Normal
        {
            get { return this.normal; }
        }

        public MenuColor Highlighted
        {
            get { return this.highlighted; }
        }

        public MenuTemplate(ConsoleColor normalBackground, ConsoleColor normalForeground, ConsoleColor highlightedBackground, ConsoleColor highlightedForeground)
            : this(new MenuColor(normalBackground, normalForeground), new MenuColor(highlightedBackground, highlightedForeground))
        {
        }

        public MenuTemplate(MenuColor normal, MenuColor highlighted)
        {
            this.normal = normal;
            this.highlighted = highlighted;
        }

    }
}
