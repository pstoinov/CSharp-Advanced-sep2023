using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split(' ');
                string name = tokens[0];
                string id = tokens[1];
                int age = int.Parse(tokens[2]);

                Person foundPerson = persons.FirstOrDefault(x => x.Id == name);
                if (foundPerson != null)
                {
                    foundPerson.Age = age;
                    foundPerson.Name = name;   
                }
                else
                {
                    persons.Add(new Person(name, id, age));
                }
            }

            List<Person> orderedList = persons.OrderBy(x => x.Age).ToList();
            foreach (var person in orderedList)
            {
                Console.WriteLine(person);
            }
        }

        class Person
        {
            public Person(string name, string id, int age)
            {
                Name = name;
                Id = id;
                Age = age;
            }

            public string Name { get; set; }
            public string Id { get; set; }
            public int Age { get; set; }

            public override string ToString()
            {
                return $"{Name} with ID: {Id} is {Age} years old.";
            }


        }
    }
}
