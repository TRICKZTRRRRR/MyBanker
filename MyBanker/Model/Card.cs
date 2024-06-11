using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.Models
{
    public abstract class Card
    {
        // Property for the card number
        public string CardNumber { get; set; }

        // Property for the account number
        public string AccountNumber { get; set; }

        // Property for the card holder's name
        public string CardHolderName { get; set; }

        // Property for the expiry date of the card
        public DateTime ExpiryDate { get; set; }

        // Property for the card type
        public string CardType { get; set; }

        // Abstract method to generate the card number, to be implemented by derived classes
        public abstract void GenerateCardNumber();

        // Method to generate a random number of specified length
        protected string GenerateRandomNumber(int length)
        {
            Random random = new Random();
            string number = "";
            for (int i = 0; i < length; i++)
            {
                number += random.Next(0, 10).ToString();
            }
            return number;
        }

        // Override the ToString method to provide a string representation of the card
        public override string ToString()
        {
            return $"Card Type: {CardType}\nCard Holder: {CardHolderName}\nCard Number: {CardNumber}\nAccount Number: {AccountNumber}\nExpiry Date: {ExpiryDate.ToShortDateString()}";
        }
    }
}

