using MyBanker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.Model
{
    // Abstract class representing a debit card, inherits from Card
    public abstract class DebitCard : Card
    {
        // Override the GenerateCardNumber method from the Card class
        public override void GenerateCardNumber()
        {
            // No implementation needed here, since derived classes will implement GenerateCardNumber
        }
    }
}

