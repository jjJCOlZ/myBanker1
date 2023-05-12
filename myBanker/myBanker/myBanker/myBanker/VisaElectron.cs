using System;
using System.Text;

namespace MyBanker
{
    internal class VisaElectron : Young, IExpire, IMonthDrawLimit, IInternationalUsage
    {
        public DateTime ExpireDate { get; set; } = DateTime.Now.AddYears(5);
        public double MonthlyWithdrawalLimit { get; } = 10000;
        public bool IsInternationalUsageEnabled { get; set; } = true;

        public override string GenerateCardNumber()
        {
            StringBuilder cardNumber = new StringBuilder();
            Random random = new Random();

            string prefix = GetPrefixForCardType(CardType.VisaElectron);
            cardNumber.Append(prefix);

            for (int i = 0; i < 12; i++)
            {
                cardNumber.Append(random.Next(10));
            }

            return cardNumber.ToString();
        }

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