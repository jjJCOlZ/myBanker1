using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{//Card is a superclass
    public abstract class Card
    {   //properties
        public string Name { get; set; }
        public string CardNumber { get; set; }
        public string AccountNumber { get; set; }

        public virtual string GenerateAccountNumber()
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

        public abstract string GenerateCardNumber();

        protected string GetPrefixForCardType(CardType type)
        {
            switch (type)
            {
                case CardType.VisaElectron:
                    return "4026";
                case CardType.Visa:
                    return "4";
                case CardType.Mastercard:
                    return "5";
                case CardType.Maestro:
                    return "5018";
                case CardType.ATM:
                    return "2400";
                default:
                    return "";
            }
        }
    }

    //the different cardtypes there is in the system. Optimalt så skulle dette slettes.
    public enum CardType
    {
        VisaElectron,
        Visa,
        Mastercard,
        Maestro,
        ATM
    }
}