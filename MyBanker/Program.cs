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
        static void Main(string[] args)
        {
            var cardController = new CardController();
            var cardView = new CardView();
            var random = new Random();
            var cardTypes = new List<string> { "Maestro", "VisaElectron", "VisaDankort", "MasterCard" };
            var cards = new List<Card>();

            for (int i = 0; i < 100; i++)
            {
                string randomCardType = cardTypes[random.Next(cardTypes.Count)];
                var card = cardController.CreateCard(randomCardType);
                cards.Add(card);
            }

            foreach (var card in cards)
            {
                cardView.DisplayCardDetails(card);
            }
            Console.ReadLine();
        }
    }
}
