using MyBanker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.View
{
    // Class to handle displaying card details
    public class CardView
    {
        // Method to display the details of a given card
        public void DisplayCardDetails(Card card)
        {
            // Print the card details to the console
            Console.WriteLine("\n" + card.ToString());
        }
    }
}

