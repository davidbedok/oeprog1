using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOInto
{
    public class Program
    {

        private static void testPerson()
        {
            Console.WriteLine("# testPerson");

            Console.WriteLine("People counter: " + Person.getPeopleCounter());

            Person person = new Person("Nemecsek Erno", 1907, HairType.CURLY);
            person.setNickName("nemerno07");
            person.NickName = "nemerno";
            person.setHeight(171);
            person.Height = -21;
            person.setWeight(65);
            person.Weight = 66;
            String nick = person.getNickName();
            Console.WriteLine(nick + "'s height: " + person.getHeight() + " cm");
            Console.WriteLine(nick + "'s weight: " + person.getWeight() + " kg");
            Console.WriteLine(person.NickName + "'s height: " + person.Height + " cm");
            Console.WriteLine(person.NickName + "'s weight: " + person.Weight + " kg");
            Console.WriteLine(nick + "'s height: " + person.getHeightInInches()
                    + " inches");
            Console.WriteLine(person.getBirthName() + " was born in "
                    + person.getBirthYear() + ".");
            Console.WriteLine("Length of nick: " + person.lengthOfNick());
            Console.WriteLine("Age: " + person.age());
            Console.WriteLine("People counter: " + Person.getPeopleCounter());

            person.getHair().setColor("brown");
            Console.WriteLine("Hair: " + person.getHair().getColor() + " and "
                    + person.getHair().getType());
      
            Console.WriteLine("Hair: " + person.getHair().ToString());

        }

        private static void testPersonSimple()
        {
            Console.WriteLine("# testPersonSimple");

            Person person = new Person("Nemecsek Erno", 1907, HairType.CURLY);
            person.setNickName("nemerno");
            person.setHeight(171);
            person.setWeight(65);
            person.getHair().setColor("brown");

            Console.WriteLine(person);

        }

        private static void testPeopleCatalog()
        {
            Console.WriteLine("# testPeopleCatalog");
            PeopleCatalog catalog = new PeopleCatalog();
            catalog.addPerson("Teszt Elek", 1990, HairType.STRAIGHT);
            catalog.addPerson("Darth Vader", 1981, HairType.BALD);
            catalog.addPerson("Mezga Geza", 1967, HairType.CURLY);
            catalog.addPerson("Sebaj Tobias", 1994, HairType.CURLY);
            catalog.addPerson("Nemecsek Erno", 1907, HairType.CURLY);
            catalog.addPerson("Piszkos Fred", 1949, HairType.STRAIGHT);

            Console.WriteLine(catalog);
        }

        private static PeopleCatalog createPeopleCatalog()
        {
            PeopleCatalog catalog = new PeopleCatalog();
            catalog.addPerson("Teszt Elek", 1990, HairType.STRAIGHT);
            catalog.addPerson("Darth Vader", 1981, HairType.BALD);
            catalog.addPerson("Mezga Geza", 1967, HairType.CURLY);
            catalog.addPerson("Sebaj Tobias", 1994, HairType.CURLY);
            catalog.addPerson("Nemecsek Erno", 1907, HairType.CURLY);
            catalog.addPerson("Piszkos Fred", 1949, HairType.STRAIGHT);
            return catalog;
        }

        private static void testFindPerson()
        {
            PeopleCatalog catalog = Program.createPeopleCatalog();
            int darthVaderAge = catalog.find("Darth Vader").age();
            Console.WriteLine("Darth Vader age: " + darthVaderAge);

            Person sebajTobias = catalog.find("Sebaj Tobias");
            if (sebajTobias != null)
            {
                sebajTobias.setHeight(123);
                sebajTobias.setWeight(35);
                sebajTobias.getHair().setColor("yellow");
            }
            Console.WriteLine(catalog);
        }

        private static void testAverageAge()
        {
            PeopleCatalog catalog = Program.createPeopleCatalog();
            Console.WriteLine("average age: " + catalog.averageAge());
        }


        private static void Main(string[] args)
        {
            Program.testPerson();
            Program.testPersonSimple();
            Program.testPeopleCatalog();
            Program.testFindPerson();
            Program.testAverageAge();
        }
    }
}
