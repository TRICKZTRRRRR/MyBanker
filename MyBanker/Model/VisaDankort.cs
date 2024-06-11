using MyBanker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.Model
{
    // Class representing a Visa Dankort, inherits from Card
    public class VisaDankort : Card
    {
        // Constructor to initialize the Visa Dankort properties
        public VisaDankort()
        {
            // Assign a random name to the card holder
            CardHolderName = RandomNameGenerator.GenerateName();

            // Generate a random 14-digit account number
            AccountNumber = GenerateRandomNumber(14);

            // Set the expiry date to 5 years from now
            ExpiryDate = DateTime.Now.AddYears(5);

            // Set the card type to "Visa Dankort"
            CardType = "Visa Dankort";

            // Generate the card number
            GenerateCardNumber();
        }

        // Override the GenerateCardNumber method to generate a Visa Dankort number
        public override void GenerateCardNumber()
        {
            // Prefix for Visa Dankort numbers
            string prefix = "4";

            // Generate a random 15-digit number
            string randomPart = GenerateRandomNumber(15);

            // Combine prefix and random part to form the card number
            CardNumber = prefix + randomPart;
        }
    }
}
