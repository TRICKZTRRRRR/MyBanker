using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.Model
{
    public abstract class Cards
    {
        public string CardholdersName { get; set; }
        public string CardType { get; set; }
        public string CardNumber { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string AccountNumber { get; set; }
    }
}
