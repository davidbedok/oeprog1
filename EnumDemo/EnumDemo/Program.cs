using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnumDemo
{
    public class Program
    {

        public static void testSimpleEdgeType()
        {
            Console.WriteLine("# Test Simple Edge Type");

            SimpleEdgeType normalEdge = SimpleEdgeType.NORMAL;
            Console.WriteLine(normalEdge + " --> " + (int)normalEdge);

            SimpleEdgeType reset = (SimpleEdgeType)1;
            Console.WriteLine(reset + " --> " + (int)reset + " (" + Enum.IsDefined(typeof(SimpleEdgeType), reset) + ")");

            SimpleEdgeType unknown = (SimpleEdgeType)42;
            Console.WriteLine(unknown + " --> " + (int)unknown + " (" + Enum.IsDefined(typeof(SimpleEdgeType), unknown) + ")");

            SimpleEdgeType zeroEdgeType = new SimpleEdgeType();
            Console.WriteLine("'new' " + zeroEdgeType + " --> " + (int)zeroEdgeType);

            SimpleEdgeType inhibitor = (SimpleEdgeType)Enum.Parse(typeof(SimpleEdgeType), "INHIBITOR");
            Console.WriteLine(inhibitor + " --> " + (int)inhibitor);

            String inhibitorStr = Enum.GetName(typeof(SimpleEdgeType), SimpleEdgeType.INHIBITOR);
            Console.WriteLine(inhibitorStr);

            SimpleEdgeType whatIsIt = SimpleEdgeType.NORMAL + 2;
            Console.WriteLine(whatIsIt + " --> " + (int)inhibitor);

            Console.WriteLine("All values:");
            SimpleEdgeType[] edgeTypes = (SimpleEdgeType[])Enum.GetValues(typeof(SimpleEdgeType));
            for (int i = 0; i < edgeTypes.Length; i++)
            {
                Console.WriteLine(edgeTypes[i] + " --> " + (int)edgeTypes[i]);
            }

            Console.WriteLine("All names:");
            String[] enumStrs = Enum.GetNames(typeof(SimpleEdgeType));
            for (int i = 0; i < edgeTypes.Length; i++)
            {
                Console.WriteLine(enumStrs[i]);
            }
        }

        public static void testSimpleEdgeTypeWithExtension()
        {
            System.Console.WriteLine("# Test Simple Edge Type with Extension (from .NET 3.0)");

            SimpleEdgeType normalEdge = SimpleEdgeType.NORMAL;
            Console.WriteLine("Label of " + normalEdge + " edge type: " + normalEdge.getLabel());
            Console.WriteLine("getDefault: " + SimpleEdgeType.INHIBITOR.getDefault());
            Console.WriteLine("Custom ordinal of RESET: " + SimpleEdgeType.RESET.getCustomOrdinal(5));
        }

        public static void testEdgeTypeWithAttribute()
        {
            System.Console.WriteLine("# Test Edge Type with Attribute");

            System.Console.WriteLine("Reset NAME: " + CustomHelpers.getAttribute(EdgeTypeWithAttribute.RESET).Name);
            System.Console.WriteLine("Reset VALUE: " + CustomHelpers.getAttribute(EdgeTypeWithAttribute.RESET).Value);

            System.Console.WriteLine();
        }

        public static void testEdgeType()
        {
            System.Console.WriteLine("# Test Edge Type");

            System.Console.WriteLine(EdgeType.RESET);
            System.Console.WriteLine(EdgeType.RESET.Name);
            System.Console.WriteLine(EdgeType.RESET.Value);

            System.Console.WriteLine(EdgeType.getEnumByValue("INHIBITOR"));

            EdgeType[] enums = EdgeType.Values;
            for (int i = 0; i < enums.Length; i++)
            {
                System.Console.WriteLine(enums[i].Value + " - " + enums[i].Name);
            }

            System.Console.WriteLine();
        }

        private static void testEdgeTypeClass()
        {
            EdgeTypeClass normal = EdgeTypeClass.NORMAL;
            Console.WriteLine(normal + " --> " + normal.GetOrdinal());

            EdgeTypeClass inhibitor = EdgeTypeClass.Values[1];
            Console.WriteLine(inhibitor + " --> " + inhibitor.GetOrdinal());

            EdgeTypeClass reset = EdgeTypeClass.Parse("RESET");
            Console.WriteLine(reset + " --> " + reset.GetOrdinal());

            foreach (EdgeTypeClass edgeType in EdgeTypeClass.Values)
            {
                Console.WriteLine(edgeType + " --> " + edgeType.GetOrdinal());
            }
        }

        private static void Main(string[] args)
        {
            // Program.testSimpleEdgeType();
            // Program.testSimpleEdgeTypeWithExtension();
            // Program.testEdgeTypeWithAttribute();
            // Program.testEdgeType();

            testEdgeTypeClass();
        }
    }
}
