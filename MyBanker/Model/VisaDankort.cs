using MyBanker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.Model
{
    public class VisaDankort : Card
    {
        public VisaDankort()
        {
            CardHolderName = RandomNameGenerator.GenerateName();
            AccountNumber = GenerateRandomNumber(14);
            ExpiryDate = DateTime.Now.AddYears(5);
            CardType = "Visa Dankort";
            GenerateCardNumber();
        }

        public override void GenerateCardNumber()
        {
            string prefix = "4";
            string randomPart = GenerateRandomNumber(15);
            CardNumber = prefix + randomPart;
        }
    }
}
