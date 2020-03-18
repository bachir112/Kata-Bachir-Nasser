using Kata.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.Services
{
    class Transaction
    {
        private Global.Global.transactionDirection transactionInOrOut { get; set; }
        private decimal transactionAmount { get; set; }
        private string transactionCurrencyCode { get; set; }
        private DateTime transactionOn { get; set; }

        Transaction(Global.Global.transactionDirection transactionInOrOut, decimal transactionAmount, string transactionCurrencyCode, DateTime transactionOn)
        {
            this.transactionInOrOut = transactionInOrOut;
            this.transactionCurrencyCode = transactionCurrencyCode;
            this.transactionAmount = transactionAmount;
            this.transactionOn = transactionOn;
        }

        public Transaction(Account account, Global.Global.transactionDirection transactionInOrOut, decimal transactionAmount, string transactionCurrencyCode, DateTime transactionOn)
        {
            decimal accountAvailableAmount = account.getAccountAmount();

            //check for exchange
            if(transactionCurrencyCode != account.getAccountCurrencyCode())
            {
                throw new Exception("Exchange not allowed, please repeat this transaction with this currency " + account.getAccountCurrencyCode());
            }

            Transaction transaction = new Transaction(transactionInOrOut, transactionAmount, transactionCurrencyCode, transactionOn);

            switch (transactionInOrOut)
            {
                case Global.Global.transactionDirection.Out:
                    if(transactionAmount > accountAvailableAmount)
                    {
                        throw new Exception(String.Format("Amount exceeds available balance. Available balance: {0} {1}", account.getAccountAmount().ToString(), account.getAccountCurrencyCode()));
                    }
                    else
                    {
                        decimal newOutAmountAvailable = accountAvailableAmount - transactionAmount;
                        account.setAccountAmount(newOutAmountAvailable);
                        account.addTransaction(transaction);
                    }
                    break;

                case Global.Global.transactionDirection.In:
                    decimal newInAmountAvailable = accountAvailableAmount + transactionAmount;
                    account.setAccountAmount(newInAmountAvailable);
                    account.addTransaction(transaction);
                    break;

                default:
                    throw new Exception("Transaction could not be completed");
            }
        }

        public Global.Global.transactionDirection getTransactionInOrOut()
        {
            return this.transactionInOrOut;
        }

        public decimal getTransactionAmount()
        {
            return this.transactionAmount;
        }

        public string getTransactionCurrencyCode()
        {
            return this.transactionCurrencyCode;
        }

        public DateTime getTransactionOn()
        {
            return this.transactionOn;
        }
    }
}
