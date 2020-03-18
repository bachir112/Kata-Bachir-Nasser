using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.Classes
{
    class Customer
    {
        public Customer()
        {

        }
        public Customer(string customerID, string customerFirstName, string customerLastName, string customerAddress, string customerPhoneNumber, string customerEmail)
        {
            this.customerID = customerID;
            this.customerFirstName = customerFirstName;
            this.customerLastName = customerLastName;
            this.customerAddress = customerAddress;
            this.customerPhoneNumber = customerPhoneNumber;
            this.customerEmail = customerEmail;
        }

        string customerID { get; set; }
        string customerFirstName { get; set; }
        string customerLastName { get; set; }
        string customerAddress { get; set; }
        string customerPhoneNumber { get; set; }
        string customerEmail { get; set; }

        public void setCustomer(Customer customer)
        {
            this.Equals(customer);
        }

        public void setCustomerID(string customerID)
        {
            this.customerID = customerID;
        }

        public void setCustomerFirstName(string customerFirstName)
        {
            this.customerFirstName = customerFirstName;
        }

        public void setCustomerLastName(string customerLastName)
        {
            this.customerLastName = customerLastName;
        }

        public void setCustomerAddress(string customerAddress)
        {
            this.customerAddress = customerAddress;
        }

        public void setCustomerPhoneNumber(string customerPhoneNumber)
        {
            this.customerPhoneNumber = customerPhoneNumber;
        }

        public void setCustomerEmail(string customerEmail)
        {
            this.customerEmail = customerEmail;
        }

        public string getCustomerID()
        {
            return this.customerID;
        }

        public string getCustomerFirstName()
        {
            return this.customerFirstName;
        }

        public string getCustomerLastName()
        {
            return this.customerLastName;
        }

        public string getCustomerAddress()
        {
            return this.customerAddress;
        }

        public string getCustomerPhoneNumber()
        {
            return this.customerPhoneNumber;
        }

        public string getCustomerEmail()
        {
            return this.customerEmail;
        }
    }
}
