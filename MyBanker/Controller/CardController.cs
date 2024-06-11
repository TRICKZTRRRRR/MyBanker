using MyBanker.Model;
using MyBanker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.Controllers
{
    public class CardController
    {
        public Card CreateCard(string cardType)
        {
            Card card = null;

            switch (cardType)
            {
                case "Maestro":
                    card = new Maestro();
                    break;
                case "VisaElectron":
                    card = new VisaElectron();
                    break;
                case "VisaDankort":
                    card = new VisaDankort();
                    break;
                case "MasterCard":
                    card = new MasterCard();
                    break;
            }

            return card;
        }
    }
}
