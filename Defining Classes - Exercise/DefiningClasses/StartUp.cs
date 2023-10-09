using System;
using System.Collections.Generic;
using System.Linq;
using DefiningClasses;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family familyMembers = new();

            for (int i = 0; i < n; i++) 
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                familyMembers.addFamilyMember(input[0], int.Parse(input[1]));
            }

            /*03. Oldest Family Member
            Person oldestMember = familyMembers.getOldestFamilyMember();
            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
            */
            Family filteredFamily = familyMembers.Over30OrderByAlphabetic();
            filteredFamily.PrintFamilyMembers();
        }
    }
}