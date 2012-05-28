using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComplexProgTheorem
{

    public class Person
    {
        private string name;
        private int cardNumber;
        private SexType sexType;
        private int numberOfMatchStick; //gyufaszal
        private Person father;
        private Person mother;

        public string Name
        {
            get { return this.name; }
        }

        public SexType SexType
        {
            get { return this.sexType; }
        }

        public int NumberOfMatchStick
        {
            get { return this.numberOfMatchStick; }
        }

        public int CardNumber
        {
            get { return this.cardNumber; }
        }

        public Person Mother
        {
            get { return this.mother; }
            set { this.mother = value; }
        }

        public Person Father
        {
            get { return this.father; }
            set { this.father = value; }
        }

        public Person(string name, int cardNumber, SexType sexType, int numberOfMatchStick)
        {
            this.name = name;
            this.cardNumber = cardNumber;
            this.sexType = sexType;
            this.numberOfMatchStick = numberOfMatchStick;
        }

        public static Person getRandomPerson(Random rand, int i)
        {
            SexType[] allSexType = (SexType[])Enum.GetValues(typeof(SexType));
            SexType tmpSt = allSexType[rand.Next(0,allSexType.Length)];
            return new Person("Person" + (i+1), i + 1, tmpSt, rand.Next(100));
        }

        public string print()
        {
            return this.name + " ("+this.cardNumber+")";
        }

        public override string ToString()
        {
            string addon = "";
            if (this.mother.Equals(this.father))
            {
                addon = "Error in parent!";
            }
            if (this.Equals(this.father))
            {
                addon = "Error in father!";
            }
            if (this.Equals(this.mother))
            {
                addon = "Error in mother!";
            }
            return this.print() + " " +this.sexType + " [Mother: " + this.mother.print() + "] [Father: " + this.father.print() + "] Family: " + this.getFamilyCollection() + " " + addon;
        }

        public override int GetHashCode()
        {
            return this.cardNumber;
        }

        public override bool Equals(object obj)
        {
            bool ret = false;
            if (obj is Person)
            {
                ret = (obj as Person).GetHashCode().Equals(this.cardNumber.GetHashCode());
            }
            return ret;
        }

        public int getFamilyCollection()
        {
            return this.NumberOfMatchStick + this.mother.NumberOfMatchStick + this.father.NumberOfMatchStick;
        }

    }
}
