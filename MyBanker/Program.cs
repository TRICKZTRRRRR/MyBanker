using MyBanker.Controllers;
using MyBanker.Models;
using MyBanker.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    internal class Program
    {
        // Main entry point of the program
        static void Main(string[] args)
        {
            // Create an instance of CardController to manage card creation
            var cardController = new CardController();

            // Create an instance of CardView to display card details
            var cardView = new CardView();

            // Create an instance of Random to generate random numbers
            var random = new Random();

            // List of possible card types
            var cardTypes = new List<string> { "Maestro", "VisaElectron", "VisaDankort", "MasterCard" };

            // List to store created cards
            var cards = new List<Card>();

            // Loop to create 100 random cards
            for (int i = 0; i < 100; i++)
            {
                // Select a random card type from the list
                string randomCardType = cardTypes[random.Next(cardTypes.Count)];

                // Create a card of the selected type
                var card = cardController.CreateCard(randomCardType);

                // Add the created card to the list
                cards.Add(card);
            }

            // Loop to display details of each card
            foreach (var card in cards)
            {
                // Display the card details using CardView
                cardView.DisplayCardDetails(card);
            }

            // Wait for user input before closing the program
            Console.ReadLine();
        }
    }
}

