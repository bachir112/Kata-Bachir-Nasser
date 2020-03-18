using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.Classes
{
    class Bank
    {
        public Bank()
        {

        }

        public Bank(string bankID, string bankName, string bankCountryCode, string bankSwiftCode, string bankAddress)
        {
            this.bankID = bankID;
            this.bankName = bankName;
            this.bankSwiftCode = bankSwiftCode;
            this.bankAddress = bankAddress;
        }

        private string bankID {get;set;}
        private string bankName { get; set; }
        private string bankCountryCode { get; set; }
        private string bankSwiftCode { get; set; }
        private string bankAddress { get; set; }

        private List<Account> accounts = new List<Account>();


        public string getBankID()
        {
            return this.bankName;
        }

        public string getBankName()
        {
            return this.bankName;
        }

        public string getBankCountryCode()
        {
            return this.bankCountryCode;
        }

        public string getBankSwiftCode()
        {
            return this.bankSwiftCode;
        }

        public string getBankAddress()
        {
            return this.bankAddress;
        }


        public void setBankID(string bankName)
        {
            this.bankName = bankName;
        }

        public void setBankName(string bankName)
        {
            this.bankName = bankName;
        }

        public void setBankCountryCode(string bankCountryCode)
        {
            this.bankCountryCode = bankCountryCode;
        }

        public void setBankSwiftCode(string bankSwiftCode)
        {
            this.bankSwiftCode = bankSwiftCode;
        }

        public void setBankAddress(string bankAddress)
        {
            this.bankAddress = bankAddress;
        }

        public void addAccount(Account account)
        {
            List<Account> accounts = this.accounts;
            accounts.Add(account);

            this.accounts = accounts;
        }

        public void removeAccount(Account account)
        {
            this.accounts.Remove(account);
        }

        ~Bank()
        {
            //This method cant be called manually. However it will write Bank Destroyed once the garbage collector destroys this bank
            Console.WriteLine("Bank Destroyed");
        }
    }
}
