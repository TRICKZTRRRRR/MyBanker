using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.Model
{
    public static class RandomNameGenerator
    {
        private static List<string> firstNames = new List<string> { "Morten", "David", "Anders", "Matias", "Jonas", "Simon" };
        private static List<string> lastNames = new List<string> { "Hansen", "Mågensen", "Andersen", "Hvid", "Sten", "Hanner" };
        private static Random random = new Random();

        public static string GenerateName()
        {
            string firstName = firstNames[random.Next(firstNames.Count)];
            string lastName = lastNames[random.Next(lastNames.Count)];
            return $"{firstName} {lastName}";
        }
    }
}
