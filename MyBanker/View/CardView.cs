using MyBanker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.View
{
    public class CardView
    {
        public void DisplayCardDetails(Card card)
        {
            Console.WriteLine("\n" + card.ToString());
        }
    }
}
