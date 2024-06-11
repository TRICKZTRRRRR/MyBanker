using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.Model
{
    // Class representing a Visa Electron card, inherits from DebitCard
    public class VisaElectron : DebitCard
    {
        // Constructor to initialize the Visa Electron properties
        public VisaElectron()
        {
            // Assign a random name to the card holder
            CardHolderName = RandomNameGenerator.GenerateName();

            // Generate a random 14-digit account number
            AccountNumber = GenerateRandomNumber(14);

            // Set the expiry date to 5 years from now
            ExpiryDate = DateTime.Now.AddYears(5);

            // Set the card type to "Visa Electron"
            CardType = "Visa Electron";

            // Generate the card number
            GenerateCardNumber();
        }

        // Override the GenerateCardNumber method to generate a Visa Electron card number
        public override void GenerateCardNumber()
        {
            // Prefix for Visa Electron card numbers
            string prefix = "4026";

            // Generate a random 12-digit number
            string randomPart = GenerateRandomNumber(12);

            // Combine prefix and random part to form the card number
            CardNumber = prefix + randomPart;
        }
    }
}

