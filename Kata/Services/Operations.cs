using Kata.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.Services
{
    class Operations
    {
        public static void viewOperations(Bank bank, Account account)
        {
            Console.WriteLine(String.Format("Bank: {0}", bank.getBankName()));
            Console.WriteLine(String.Format("Customer Name: {0} {1}", account.getCustomerFirstName(), account.getCustomerLastName()));
            Console.WriteLine(String.Format("Receipt Printed On: {0}", DateTime.UtcNow.ToString("dd-MMM-yyyy")));
            Console.WriteLine(String.Format("Account Number: {0}", account.getAccountNumber()));
            Console.WriteLine(String.Format("Avalaible Balance: {0} {1}", account.getAccountAmount(), account.getAccountCurrencyCode()));
            Console.WriteLine("--------------Transactions----------------");
            foreach(var transaction in account.getListOfTransactions())
            {
                Console.WriteLine(String.Format("Amount: {0} {1}, Date: {2}, Type: {3}", transaction.getTransactionAmount(), transaction.getTransactionCurrencyCode(), transaction.getTransactionOn(), (transaction.getTransactionInOrOut() == Global.Global.transactionDirection.In ? "Deposit" : "Withdrawal")));
            }
        }
    }
}
