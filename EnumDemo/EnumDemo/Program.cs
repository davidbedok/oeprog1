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
            System.Console.WriteLine("# Test Simple Edge Type");

            SimpleEdgeType normalEdge = SimpleEdgeType.NORMAL;
            System.Console.WriteLine(normalEdge + " - " + (int)normalEdge);
            System.Console.WriteLine();

            SimpleEdgeType reset = (SimpleEdgeType)2;
            System.Console.WriteLine(reset + " - " + (int)reset);
            System.Console.WriteLine();

            SimpleEdgeType edgeType = new SimpleEdgeType();
            System.Console.WriteLine(edgeType + " - " + (int)edgeType);
            System.Console.WriteLine();

            SimpleEdgeType inhibitor = (SimpleEdgeType)Enum.Parse(typeof(SimpleEdgeType), "INHIBITOR");
            System.Console.WriteLine(inhibitor + " - " + (int)inhibitor);
            System.Console.WriteLine();

            string inhibitorStr = Enum.GetName(typeof(SimpleEdgeType), SimpleEdgeType.INHIBITOR);
            System.Console.WriteLine(inhibitorStr);
            System.Console.WriteLine();

            SimpleEdgeType[] enums = (SimpleEdgeType[])Enum.GetValues(typeof(SimpleEdgeType));
            for (int i = 0; i < enums.Length; i++)
            {
                System.Console.WriteLine(enums[i] + " - " + (int)enums[i]);
            }

            string[] enumStrs = Enum.GetNames(typeof(SimpleEdgeType));
            for (int i = 0; i < enums.Length; i++)
            {
                System.Console.WriteLine(enumStrs[i]);
            }

            System.Console.WriteLine();
        }

        public static void testSimpleEdgeTypeWithExtension()
        {
            System.Console.WriteLine("# Test Simple Edge Type with Extension (from .NET 3.0)");

            SimpleEdgeType normalEdge = SimpleEdgeType.NORMAL;
            System.Console.WriteLine("customToString: " + normalEdge.customToString());
            System.Console.WriteLine("getDefault: " + SimpleEdgeType.INHIBITOR.getDefault());
            System.Console.WriteLine("customCalculate: " + SimpleEdgeType.INHIBITOR.customCalculate());
            System.Console.WriteLine("customCalculate with param: " + SimpleEdgeType.INHIBITOR.customCalculate(3));
    
            System.Console.WriteLine();

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

        private static void Main(string[] args)
        {
            Program.testSimpleEdgeType();
            Program.testSimpleEdgeTypeWithExtension();
            Program.testEdgeTypeWithAttribute();
            Program.testEdgeType();
        }
    }
}
