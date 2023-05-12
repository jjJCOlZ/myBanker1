using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    //ADult inherit from Card
    public class Adult : Card
    {
        //Generating a cardnumber - Dette burde jeg slette, men koden driller når jeg gør det. 
        public override string GenerateCardNumber()
        {
            StringBuilder cardNumber = new StringBuilder();
            Random random = new Random();

            string prefix = GetPrefixForCardType(CardType.Visa);
            cardNumber.Append(prefix);

            for (int i = 0; i < 15; i++)
            {
                cardNumber.Append(random.Next(10));
            }

            return cardNumber.ToString();
        }
        //Generating a accountnumber - Dette burde jeg slette, men koden driller når jeg gør det. 
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