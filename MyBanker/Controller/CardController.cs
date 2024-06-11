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
        // Method to create a card based on the provided card type
        public Card CreateCard(string cardType)
        {
            // Initialize card variable
            Card card = null;

            // Switch statement to determine which card to create based on cardType
            switch (cardType)
            {
                case "Maestro":
                    // Create a Maestro card
                    card = new Maestro();
                    break;
                case "VisaElectron":
                    // Create a Visa Electron card
                    card = new VisaElectron();
                    break;
                case "VisaDankort":
                    // Create a Visa Dankort card
                    card = new VisaDankort();
                    break;
                case "MasterCard":
                    // Create a MasterCard
                    card = new MasterCard();
                    break;
                default:
                    // Throw an exception if an invalid card type is provided
                    throw new ArgumentException("Invalid card type");
            }

            // Return the created card
            return card;
        }
    }
}


