using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.Models
{
    public abstract class Card
    {
        public string CardNumber { get; set; }
        public string AccountNumber { get; set; }
        public string CardHolderName { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string CardType { get; set; }

        public abstract void GenerateCardNumber();

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

        public override string ToString()
        {
            return $"Card Type: {CardType}\nCard Holder: {CardHolderName}\nCard Number: {CardNumber}\nAccount Number: {AccountNumber}\nExpiry Date: {ExpiryDate.ToShortDateString()}";
        }
    }
}
