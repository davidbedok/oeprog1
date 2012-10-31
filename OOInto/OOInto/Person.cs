using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOInto
{
    public class Person
    {
        
        private const double CM2INCH = 0.393700787;

        private static int peopleCounter = 0;

        private readonly String birthName;
        private readonly int birthYear;

        private String nickName;
        private int height;
        private int weight;
        private double heightInInches;

        private readonly Hair hair;

        public String NickName
        {
            get { return this.nickName; }
            set { this.nickName = value; }
        }

        public int Height
        {
            get { return this.height; }
            set
            {
                if (value > 0)
                {
                    this.height = value;
                }
            }
        }

        public int Weight
        {
            get { return this.weight; }
            set
            {
                if (value > 0)
                {
                    this.weight = value;
                }
            }
        }

        public Person(String birthName, int birthYear, HairType typeOfHair)
        {
            this.birthName = birthName;
            this.birthYear = birthYear;
            this.hair = new Hair(typeOfHair);
            Person.peopleCounter++;
        }

        ~Person()
        {
            Person.peopleCounter--;
        }

        public String getNickName()
        {
            return this.nickName;
        }

        public void setNickName(String nickName)
        {
            this.nickName = nickName;
        }

        public int getHeight()
        {
            return this.height;
        }

        public void setHeight(int height)
        {
            if (height > 0)
            {
                this.height = height;
                this.heightInInches = height * Person.CM2INCH;
            }
        }

        public int getWeight()
        {
            return this.weight;
        }

        public void setWeight(int weight)
        {
            if (weight > 0)
            {
                this.weight = weight;
            }
        }

        public double getHeightInInches()
        {
            return this.heightInInches;
        }

        public String getBirthName()
        {
            return this.birthName;
        }

        public int getBirthYear()
        {
            return this.birthYear;
        }

        public static int getPeopleCounter()
        {
            return Person.peopleCounter;
        }

        public int lengthOfNick()
        {
            int length = 0;
            if (this.nickName != null)
            {
                length = this.nickName.Length;
            }
            return length;
        }

        public int age()
        {
            return DateTime.Now.Year - this.getBirthYear();
        }

        public Hair getHair()
        {
            return this.hair;
        }

        public override String ToString()
        {
            StringBuilder info = new StringBuilder();

            info.Append(this.birthName).Append(" was born in ")
                    .Append(this.birthYear).Append(" (").Append(this.age())
                    .Append(" year(s) old)").Append(".\n");
            info.Append("(S)he is ").Append(this.height).Append(" cm high and ")
                    .Append(this.weight).Append(" kg weight.\n");
            info.Append("His/her hair is ").Append(this.hair.ToString());
            return info.ToString();
        }

    }
}
