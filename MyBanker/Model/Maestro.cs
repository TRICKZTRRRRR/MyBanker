using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.Model
{
    // Class representing a Maestro card, inherits from DebitCard
    public class Maestro : DebitCard
    {
        // Constructor to initialize the Maestro card properties
        public Maestro()
        {
            // Assign a random name to the card holder
            CardHolderName = RandomNameGenerator.GenerateName();

            // Generate a random 14-digit account number
            AccountNumber = GenerateRandomNumber(14);

            // Set the expiry date to 5 years and 8 months from now
            ExpiryDate = DateTime.Now.AddYears(5).AddMonths(8);

            // Set the card type to "Maestro"
            CardType = "Maestro";

            // Generate the card number
            GenerateCardNumber();
        }

        // Override the GenerateCardNumber method to generate a Maestro card number
        public override void GenerateCardNumber()
        {
            // Prefix for Maestro card numbers
            string prefix = "5018";

            // Generate a random 15-digit number
            string randomPart = GenerateRandomNumber(15);

            // Combine prefix and random part to form the card number
            CardNumber = prefix + randomPart;
        }
    }
}

