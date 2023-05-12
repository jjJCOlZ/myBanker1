using System;
using MyBanker;

class Program
{
    static void Main(string[] args)
    {
        // Create a new Visa card
        Visa visa1 = new Visa();
        Console.WriteLine("Visa Card Number: " + visa1.GenerateCardNumber());
        Console.WriteLine("Visa Account Number: " + visa1.GenerateAccountNumber());
        Console.WriteLine("Visa Credit Limit: " + visa1.CreditLimit);
        Console.WriteLine("Visa Expiration Date: " + visa1.ExpireDate);
        Console.WriteLine("Visa Monthly Withdrawal Limit: " + visa1.MonthlyWithdrawalLimit);
        Console.WriteLine();

        // Create a new Mastercard
        Mastercard mastercard1 = new Mastercard();
        Console.WriteLine("Mastercard Card Number: " + mastercard1.GenerateCardNumber());
        Console.WriteLine("Mastercard Account Number: " + mastercard1.GenerateAccountNumber());
        Console.WriteLine("Mastercard Credit Limit: " + mastercard1.CreditLimit);
        Console.WriteLine("Mastercard Expiration Date: " + mastercard1.ExpireDate);
        Console.WriteLine("Mastercard Monthly Withdrawal Limit: " + mastercard1.MonthlyWithdrawalLimit);
        Console.WriteLine("Mastercard Daily Withdrawal Limit: " + mastercard1.DailyWithdrawalLimit);
        Console.WriteLine();

        // Create a new Visa Electron card
        VisaElectron visaElectron1 = new VisaElectron();
        Console.WriteLine("Visa Electron Card Number: " + visaElectron1.GenerateCardNumber());
        Console.WriteLine("Visa Electron Account Number: " + visaElectron1.GenerateAccountNumber());
        Console.WriteLine("Visa Electron Expiration Date: " + visaElectron1.ExpireDate);
        Console.WriteLine("Visa Electron Monthly Withdrawal Limit: " + visaElectron1.MonthlyWithdrawalLimit);
        Console.WriteLine();

        // Create a new ATM card
        ATM atm1 = new ATM();
        Console.WriteLine("ATM Card Number: " + atm1.GenerateCardNumber());
        Console.WriteLine("ATM Account Number: " + atm1.GenerateAccountNumber());
        Console.WriteLine();

        // Create a new Maestro card
        Maestro maestro1 = new Maestro();
        Console.WriteLine("Maestro Card Number: " + maestro1.GenerateCardNumber());
        Console.WriteLine("Maestro Account Number: " + maestro1.GenerateAccountNumber());
        Console.WriteLine("Maestro Expiration Date: " + maestro1.ExpireDate);

        Console.ReadLine();
    }
}