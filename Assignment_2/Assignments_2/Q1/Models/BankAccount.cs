using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1.Models
{
    public class BankAccount
    {
        private double balance = 10000;
        public string AccountNumber { get; }
        public string  AccountHolderName { get; set; }
        public double Balance {
            get { return  balance; }
            private set
            {
                if (value < 0) { balance = 0; }
                else { balance = value; }
            }
        }
        public BankAccount(){ }
        public BankAccount(string _AccountNumber)
        {
            AccountNumber = _AccountNumber;       
        }

        public double Withdraw(double _balance)
        {
            Balance = Balance - _balance;
            return Balance;
        }

        public double Deposite(double _balance)
        {
            Balance = Balance + _balance;
            return Balance;
        }

        public override string ToString()
        {
            return $"Account Number = {AccountNumber} and Balance = {Balance}";
        }
    }
}
