using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public class Maestro : Adult, IExpire
    {
        public DateTime ExpireDate { get; set; } = DateTime.Now.AddYears(5).AddMonths(8);
        public bool IsInternationalUsageEnabled { get; set; } = true;

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

        public override string GenerateCardNumber()
        {
            StringBuilder cardNumber = new StringBuilder();
            Random random = new Random();

            string prefix = GetPrefixForCardType(CardType.Maestro);
            cardNumber.Append(prefix);

            for (int i = 0; i < 15; i++)
            {
                cardNumber.Append(random.Next(10));
            }

            return cardNumber.ToString();
        }
    }
}