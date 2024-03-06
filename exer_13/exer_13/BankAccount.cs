using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer_13
{
    internal class BankAccount
    {
        public static int NumberOfAccounts = 0;
        int accountNumber;
        double accountBalance;

        public int AccountNumbet { get { return this.accountNumber; } }
        public double CheckBalance { get { return this.accountBalance; } }

        public BankAccount()
        {
            this.accountNumber = NumberOfAccounts;
            this.accountBalance = 0;
            NumberOfAccounts++;
        }

        public BankAccount(double initalValue)
        {
            this.accountNumber = NumberOfAccounts;
            this.accountBalance = initalValue;
            NumberOfAccounts++;
        }

        public double Deposit(double value)
        {
            this.accountBalance += Math.Abs(value);
            return this.accountBalance;
        }

        public double Withdraw(double value)
        {
            if (this.accountBalance - Math.Abs(value) < 0)
                return 0.0;
            this.accountBalance -= Math.Abs(value);
            return this.accountBalance;
        }
    }
}
