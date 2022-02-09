using BankingLibraryProject;
using System;

namespace TestBankingLibrary {

    public class Program {

        static void Main(string[] args) {

            Account account = new Account();
            account.CalculateInterest(36);
            Console.WriteLine(account.Balance);
                


        }
    }
}
