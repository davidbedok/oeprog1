using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOInto
{
    public class PeopleCatalog
    {

        private static readonly int MAX_PEOPLE_COUNT = 10;

        private readonly Person[] people;
        private int index;

        public PeopleCatalog()
        {
            this.people = new Person[PeopleCatalog.MAX_PEOPLE_COUNT];
            this.index = 0;
        }

        private void addPerson(Person person)
        {
            if (this.index < this.people.Length - 1)
            {
                this.people[this.index++] = person;
            }
        }

        public void addPerson(String birthName, int birthYear, HairType typeOfHair)
        {
            this.addPerson(new Person(birthName, birthYear, typeOfHair));
        }

        public Person find(String birthName)
        {
            Person person = null;
            if (birthName != null)
            {
                int i = 0;
                while ((i < this.index)
                        && (!birthName.Equals(this.people[i].getBirthName())))
                {
                    i++;
                }
                if (i < this.index)
                {
                    person = this.people[i];
                }
            }
            return person;
        }

        public double averageAge()
        {
            int sumAge = 0;
            for (int i = 0; i < this.index; i++)
            {
                sumAge += this.people[i].age();
            }
            return ((double)sumAge / this.index);
        }

        public override String ToString()
        {
            StringBuilder info = new StringBuilder();
            info.Append("--== People catalog ==--\n");
            for (int i = 0; i < this.index; i++)
            {
                info.Append("[").Append(i).Append("] ").Append(this.people[i])
                        .Append("\n");
            }
            return info.ToString();
        }

    }
}
