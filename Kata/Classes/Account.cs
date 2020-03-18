using Kata.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.Classes
{
    class Account : Customer
    {
        public Account()
        {

        }

        public Account (Customer customer, string accountID, string accountNumber, string accountIBAN, string accountTag25, string accountCurrencyCode, decimal accountAmount, DateTime accountOpenedOn, Nullable<DateTime> accountClosedOn = null)
        {
            this.setCustomerID(customer.getCustomerID());
            this.setCustomerFirstName(customer.getCustomerFirstName());
            this.setCustomerLastName(customer.getCustomerLastName());
            this.setCustomerAddress(customer.getCustomerAddress());
            this.setCustomerPhoneNumber(customer.getCustomerPhoneNumber());
            this.setCustomerEmail(customer.getCustomerEmail());

            this.accountID = accountID;
            this.accountNumber = accountNumber;
            this.accountIBAN = accountIBAN;
            this.accountTag25 = accountTag25;
            this.accountAmount = accountAmount;
            this.accountCurrencyCode = accountCurrencyCode;
            this.accountOpenedOn = accountOpenedOn;
            this.accountClosedOn = accountClosedOn;
        }

        private string accountID { get; set; }
        private string accountNumber { get; set; }
        private string accountIBAN { get; set; }
        private string accountTag25 { get; set; }
        private string accountCurrencyCode { get; set; }
        private decimal accountAmount { get; set; }
        private DateTime accountOpenedOn { get; set; }
        private Nullable<DateTime> accountClosedOn { get; set; }

        private List<Transaction> transactions = new List<Transaction>();

        string getAccountID()
        {
            return this.accountID;
        }

        public string getAccountNumber()
        {
            return this.accountNumber;
        }

        public string getAccountIBAN()
        {
            return this.accountIBAN;
        }

        public string getAccountTag25()
        {
            return this.accountTag25;
        }

        public string getAccountCurrencyCode()
        {
            return this.accountCurrencyCode;
        }

        public decimal getAccountAmount()
        {
            return this.accountAmount;
        }

        public DateTime getAccountOpenedOn()
        {
            return this.accountOpenedOn;
        }

        public List<Transaction> getListOfTransactions()
        {
            return this.transactions;
        }


        public Nullable<DateTime> setAccountClosedOn()
        {
            return this.accountClosedOn;
        }

        public void setAccountID(string accountID)
        {
            this.accountID = accountID;
        }

        public void setAccountNumber(string accountNumber)
        {
            this.accountNumber = accountNumber;
        }

        public void setAccountIBAN(string accountIBAN)
        {
            this.accountIBAN = accountIBAN;
        }

        public void setAccountTag25(string accountTag25)
        {
            this.accountTag25 = accountTag25;
        }

        public void setAccountCurrencyCode(string accountCurrencyCode)
        {
            this.accountCurrencyCode = accountCurrencyCode;
        }

        public void setAccountOpenedOn(DateTime accountOpenedOn)
        {
            this.accountOpenedOn = accountOpenedOn;
        }

        

        public void setAccountAmount(decimal accountAmount)
        {
            this.accountAmount = accountAmount;
        }

        public void setAccountClosedOn(DateTime accountClosedOn)
        {
            this.accountClosedOn = accountClosedOn;
        }
        public void addTransaction(Transaction transaction)
        {
            transactions.Add(transaction);
        }

        ~Account()
        {
            //This method cant be called manually. However it will write Bank Destroyed once the garbage collector destroys this bank
            Console.WriteLine("Account Destroyed");
        }
    }
}
