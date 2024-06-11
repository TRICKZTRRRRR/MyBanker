using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.Model
{
    public class Maestro : DebitCard
    {
        public Maestro()
        {
            CardHolderName = RandomNameGenerator.GenerateName();
            AccountNumber = GenerateRandomNumber(14);
            ExpiryDate = DateTime.Now.AddYears(5).AddMonths(8);
            CardType = "Maestro";
            GenerateCardNumber();
        }

        public override void GenerateCardNumber()
        {
            string prefix = "5018";
            string randomPart = GenerateRandomNumber(15);
            CardNumber = prefix + randomPart;
        }
    }
}
