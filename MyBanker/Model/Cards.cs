using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.Model
{
    internal class Cards
    {
        private string _cardholdersName { get; set; }
        private string _cardType { get; set; }
        private string _cardNumber { get; set; }
        private DateTime _expirationDate { get; set; }
        private string _accountNumber { get; set; }

        public Cards(string cardholdersName, string cardType, string cardNumber, DateTime expirationDate, string accountNumber)
        {
            _cardholdersName = cardholdersName;
            _cardType = cardType;
            _cardNumber = cardNumber;
            _expirationDate = expirationDate;
            _accountNumber = accountNumber;
        }
        
        public string CardholdersName => _cardholdersName;
        public string CardType => _cardType;
        public string CardNumber => _cardNumber;
        public DateTime ExpirationDate => _expirationDate;
        public string AccountNumber => _accountNumber;
    }
}
