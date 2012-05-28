using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComplexProgTheorem
{
    public class People
    {
        private static readonly int N = 20;

        private Person[] people;
        private Random rand;

        public People(Random rand)
        {
            this.rand = rand;
            this.people = new Person[People.N];
            for (int i = 0; i < People.N; i++)
            {
                people[i] = Person.getRandomPerson(this.rand,i);
            }
            for (int i = 0; i < People.N; i++)
            {

                people[i].Mother = this.getRelevantParent(people[i],SexType.Woman);
                people[i].Father = this.getRelevantParent(people[i],SexType.Man);         
            }
        }

        public Person getRelevantParent(Person actPerson, Person parent)
        {
            Person iPerson = null;
            do
            {
                iPerson = this.people[rand.Next(0, People.N)];
            } while ((iPerson.Equals(actPerson)) || ((parent != null ? iPerson.Equals(parent) : false)));
            return iPerson;
        }

        public Person getRelevantParent(Person actPerson, SexType sexType)
        {
            Person iPerson = null;
            do
            {
                iPerson = this.people[rand.Next(0, People.N)];
            } while ((iPerson.Equals(actPerson)) || (!iPerson.SexType.Equals(sexType)));
            return iPerson;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(200);
            for (int i = 0; i < People.N; i++)
            {
                sb.Append(this.people[i]+"\n");
            }
            return sb.ToString();
        }

        public int getAllNumberOfMatchStick(SexType sexType)
        {
            int ret = 0;
            for (int i = 0; i < People.N; i++)
            {
                if (people[i].SexType.Equals(sexType))
                {
                    ret += people[i].NumberOfMatchStick;
                }
            }
            return ret;
        }

        public Person getMaxFamilyMatchStickCollection()
        {
            int max = this.people[0].getFamilyCollection();
            int maxPos = 0;
            int tmp;
            for (int i = 1; i < People.N; i++)
            {
                tmp = this.people[i].getFamilyCollection();
                if (max < tmp)
                {
                    max = tmp;
                    maxPos = i;
                }
            }
            return people[maxPos];
        }

        public SexType getHigherMatchStickFan()
        {
            return (this.getAllNumberOfMatchStick(SexType.Man) > this.getAllNumberOfMatchStick(SexType.Woman) ? SexType.Man : SexType.Woman);
        }

    }
}
