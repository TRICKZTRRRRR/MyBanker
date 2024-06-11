using MyBanker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.Model
{
    public class MasterCard : Card
    {
        public MasterCard()
        {
            CardHolderName = RandomNameGenerator.GenerateName();
            AccountNumber = GenerateRandomNumber(14);
            ExpiryDate = DateTime.Now.AddYears(5);
            CardType = "MasterCard";
            GenerateCardNumber();
        }

        public override void GenerateCardNumber()
        {
            string prefix = "51";
            string randomPart = GenerateRandomNumber(14);
            CardNumber = prefix + randomPart;
        }
    }
}
