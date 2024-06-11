using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.Model
{
    public class VisaElectron : DebitCard
    {
        public VisaElectron()
        {
            CardHolderName = RandomNameGenerator.GenerateName();
            AccountNumber = GenerateRandomNumber(14);
            ExpiryDate = DateTime.Now.AddYears(5);
            CardType = "Visa Electron";
            GenerateCardNumber();
        }

        public override void GenerateCardNumber()
        {
            string prefix = "4026";
            string randomPart = GenerateRandomNumber(12);
            CardNumber = prefix + randomPart;
        }
    }
}
