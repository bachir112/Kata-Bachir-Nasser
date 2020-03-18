using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kata.Classes;
using Kata.Global;
using Kata.Services;

namespace Kata
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating Bank
            string bankID = Guid.NewGuid().ToString();
            string bankName = "AUDI";
            string bankCountryCode = "LB";
            string bankSwiftCode = "00000000";
            string bankAddress = "Beirut, Lebanon";

            //Check for SQL injections
            if (Global.Global.checkForSQLInjection(bankName)
                || Global.Global.checkForSQLInjection(bankCountryCode)
                || Global.Global.checkForSQLInjection(bankSwiftCode)
                || Global.Global.checkForSQLInjection(bankAddress))
            {
                throw new Exception("An SQL Injection attempt was detected on bank creation");
            }

            Bank bankAudi = new Bank(bankID, bankName, bankCountryCode, bankSwiftCode, bankAddress);
            //end creating bank


            //Creating Customer
            string customerID = Guid.NewGuid().ToString();
            string firstName = "Bachir";
            string lastName = "Nasser";
            string address = "Beirut";
            string phoneNumber = "0096170102981";
            string emailAddress = "bachir.nasser1@gmail.com";

            //Check for SQL injections
            if (Global.Global.checkForSQLInjection(firstName)
                || Global.Global.checkForSQLInjection(lastName)
                || Global.Global.checkForSQLInjection(address)
                || Global.Global.checkForSQLInjection(phoneNumber)
                || Global.Global.checkForSQLInjection(emailAddress))
            {
                throw new Exception("An SQL Injection attempt was detected on customer creation");
            }

            Customer customerOne = new Customer(customerID, firstName, lastName, address, phoneNumber, emailAddress);
            //end creating customer


            //creating account
            string accountID = Guid.NewGuid().ToString();
            string accountNumber = "00000001001901229114";
            string accountIBAN = "FR7630006000011234567890189";
            string accountTag25 = "FR7630006000011234567890189";
            string currencyCode = "USD";
            decimal accountAmount = 100;
            DateTime accountOpenedOn = DateTime.UtcNow;

            //Check for SQL injections
            if (Global.Global.checkForSQLInjection(accountNumber)
                || Global.Global.checkForSQLInjection(accountIBAN)
                || Global.Global.checkForSQLInjection(accountTag25)
                || Global.Global.checkForSQLInjection(currencyCode))
            {
                throw new Exception("An SQL Injection attempt was detected on account creation");
            }

            Account accountOne = new Account(customerOne, accountID, accountNumber, accountIBAN, accountTag25, currencyCode, accountAmount, accountOpenedOn);
            //end creating account

            //add account to bank
            bankAudi.addAccount(accountOne);

            //deposit amount
            //deposit any amount in same currency
            //Transaction transactionDepositOne = new Transaction(accountOne, Global.Global.transactionDirection.In, 200, "USD", DateTime.UtcNow);
            //deposit any amount in different currency
            //Transaction transactionDepositTwo = new Transaction(accountOne, Global.Global.transactionDirection.In, 50, "EUR", DateTime.UtcNow);


            //withdraw amount
            //withdar exceeds value in amount
            //Transaction transactionWithdrawOne = new Transaction(accountOne, Global.Global.transactionDirection.Out, 20000, "USD", DateTime.UtcNow);
            //withdar less than value in amount
            //Transaction transactionWithdrawTwo = new Transaction(accountOne, Global.Global.transactionDirection.Out, 50, "USD", DateTime.UtcNow);
            //withdar equal to value in amount
            //Transaction transactionWithdrawThree = new Transaction(accountOne, Global.Global.transactionDirection.Out, 100, "USD", DateTime.UtcNow);
            //withdar different currency
            //Transaction transactionWithdrawFour = new Transaction(accountOne, Global.Global.transactionDirection.Out, 50, "EUR", DateTime.UtcNow);

            Transaction transactionDepositThree = new Transaction(accountOne, Global.Global.transactionDirection.In, 200, "USD", DateTime.UtcNow);
            Transaction transactionDepositFour = new Transaction(accountOne, Global.Global.transactionDirection.In, 200, "USD", DateTime.UtcNow);
            Transaction transactionWithdrawOne = new Transaction(accountOne, Global.Global.transactionDirection.Out, 100, "USD", DateTime.UtcNow);
            Transaction transactionWithdrawTwo = new Transaction(accountOne, Global.Global.transactionDirection.Out, 100, "USD", DateTime.UtcNow);
            Transaction transactionWithdrawThree = new Transaction(accountOne, Global.Global.transactionDirection.Out, 100, "USD", DateTime.UtcNow);
            Operations.viewOperations(bankAudi, accountOne);

            var tt = "";
        }
    }
}
