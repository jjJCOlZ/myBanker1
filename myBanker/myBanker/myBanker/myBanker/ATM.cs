using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    internal class ATM : Young
    {

        //Generating a card number for the ATM CARD
        public override string GenerateCardNumber()
        {
            StringBuilder cardNumber = new StringBuilder();
            Random random = new Random();

            string prefix = GetPrefixForCardType(CardType.ATM);
            cardNumber.Append(prefix);

            for (int i = 0; i < 12; i++)
            {
                cardNumber.Append(random.Next(10));
            }

            return cardNumber.ToString();
        }

        //Generating a accountnumber for the ATM card
        public override string GenerateAccountNumber()
        {
            StringBuilder accountNumber = new StringBuilder();
            Random random = new Random();

            accountNumber.Append("3520");

            for (int i = 0; i < 10; i++)
            {
                accountNumber.Append(random.Next(10));
            }

            return accountNumber.ToString();
        }
    }
}