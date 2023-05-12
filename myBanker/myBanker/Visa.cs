using System;
using System.Text;

namespace MyBanker
{
    public class Visa : Adult, ICredit, IExpire, IMonthDrawLimit, IInternationalUsage
    {
        public double CreditLimit { get; set; } = 20000;
        public DateTime ExpireDate { get; set; } = DateTime.Now.AddYears(5);
        public double MonthlyWithdrawalLimit { get; set; } = 25000;
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

            string prefix = GetPrefixForCardType(CardType.Visa);
            cardNumber.Append(prefix);

            for (int i = 0; i < 15; i++)
            {
                cardNumber.Append(random.Next(10));
            }

            return cardNumber.ToString();
        }

        public double GetWithdrawalLimitPerMonth()
        {
            return MonthlyWithdrawalLimit;
        }
    }
}