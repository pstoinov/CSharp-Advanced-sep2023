using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    internal class Family
    {
		private List<Person> familyMember;


        public List<Person> FamilyMember
		{
			get { return familyMember; }
			set { familyMember = value; }
		}

        public Family()
        {
            familyMember = new List<Person>();
        }

        public void addFamilyMember(string name, int age) 
		{ 
			Person person = new Person(name, age);
            FamilyMember.Add(person);
		}

		public Person getOldestFamilyMember() 
		{
            if (familyMember.Count == 0)
            {
                return null;
            }
            Person oldestFamilyMember = FamilyMember.MaxBy(person => person.Age);
			return oldestFamilyMember;
		}

        public Family Over30OrderByAlphabetic()
        {
            if (familyMember.Count == 0)
            {
                return null;
            }

            List<Person> over30 = familyMember.Where(p => p.Age > 30).OrderBy(p => p.Name).ToList();
            Family resultFamily = new Family { FamilyMember = over30 };
            return resultFamily;
        }

        public void PrintFamilyMembers()
        {
            foreach (Person person in FamilyMember)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }

    }
}
