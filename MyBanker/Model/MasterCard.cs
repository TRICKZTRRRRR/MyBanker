using MyBanker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.Model
{
    // Class representing a MasterCard, inherits from Card
    public class MasterCard : Card
    {
        // Constructor to initialize the MasterCard properties
        public MasterCard()
        {
            // Assign a random name to the card holder
            CardHolderName = RandomNameGenerator.GenerateName();

            // Generate a random 14-digit account number
            AccountNumber = GenerateRandomNumber(14);

            // Set the expiry date to 5 years from now
            ExpiryDate = DateTime.Now.AddYears(5);

            // Set the card type to "MasterCard"
            CardType = "MasterCard";

            // Generate the card number
            GenerateCardNumber();
        }

        // Override the GenerateCardNumber method to generate a MasterCard number
        public override void GenerateCardNumber()
        {
            // Prefix for MasterCard numbers
            string prefix = "51";

            // Generate a random 14-digit number
            string randomPart = GenerateRandomNumber(14);

            // Combine prefix and random part to form the card number
            CardNumber = prefix + randomPart;
        }
    }
}

