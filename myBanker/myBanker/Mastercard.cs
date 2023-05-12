using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public class Mastercard : Adult, ICredit, IExpire, IDayDrawLimit, IMonthDrawLimit
    {
        public double CreditLimit { get; set; } = 40000;
        public DateTime ExpireDate { get; set; } = DateTime.Now.AddYears(5);
        public double MonthlyWithdrawalLimit { get; set; } = 30000;
        public double DailyWithdrawalLimit { get; } = 5000;

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

            string prefix = GetPrefixForCardType(CardType.Mastercard);
            cardNumber.Append(prefix);

            for (int i = 0; i < 14; i++)
            {
                cardNumber.Append(random.Next(10));
            }

            return cardNumber.ToString();
        }

        public double GetDailyWithdrawalLimit()
        {
            return DailyWithdrawalLimit;
        }

        public double GetMonthlyWithdrawalLimit()
        {
            return MonthlyWithdrawalLimit;
        }
    }
}