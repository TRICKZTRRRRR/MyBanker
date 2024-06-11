using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.Model
{
    // Static class for generating random names
    public static class RandomNameGenerator
    {
        // List of possible first names
        private static List<string> firstNames = new List<string> { "Morten", "David", "Anders", "Matias", "Jonas", "Simon" };

        // List of possible last names
        private static List<string> lastNames = new List<string> { "Hansen", "Mågensen", "Andersen", "Hvid", "Sten", "Hanner" };

        // Random instance for generating random numbers
        private static Random random = new Random();

        // Method to generate a random name by selecting a first name and a last name from the lists
        public static string GenerateName()
        {
            // Select a random first name
            string firstName = firstNames[random.Next(firstNames.Count)];

            // Select a random last name
            string lastName = lastNames[random.Next(lastNames.Count)];

            // Return the full name
            return $"{firstName} {lastName}";
        }
    }
}

