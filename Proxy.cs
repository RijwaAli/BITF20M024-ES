using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//task 3
namespace Assignment_7
{
    // Example 1
    interface IImage
    {
        string GetDisplay();
    }

    class RealImage : IImage
    {
        private string filename;

        public RealImage(string filename)
        {
            this.filename = filename;
            LoadImage();
        }

        private void LoadImage()
        {
            Console.WriteLine($"Loading image: {filename}");
        }

        public string GetDisplay()
        {
            return $"Displaying image: {filename}";
        }
    }

    class VirtualProxyImage : IImage
    {
        private RealImage realImage;
        private string filename;

        public VirtualProxyImage(string filename)
        {
            this.filename = filename;
        }

        public string GetDisplay()
        {
            if (realImage == null)
            {
                realImage = new RealImage(filename);
            }
            return realImage.GetDisplay();
        }
    }
    // Example 2 
    interface IAccount
    {
        void Withdraw(int amount);
    }
    class BankAccount : IAccount
    {
        private int balance;

        public BankAccount(int initialBalance)
        {
            balance = initialBalance;
        }

        public void Withdraw(int amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawal successful. Remaining balance: {balance}");
            }
            else
            {
                Console.WriteLine("Insufficient funds. Withdrawal failed.");
            }
        }
    }
    class SecureAccountProxy : IAccount
    {
        private BankAccount realAccount;
        private string password;

        public SecureAccountProxy(string password)
        {
            this.password = password;
        }

        private bool Authenticate()
        {
            // Simulate authentication logic
            return password == "secret";
        }

        public void Withdraw(int amount)
        {
            if (Authenticate())
            {
                if (realAccount == null)
                {
                    realAccount = new BankAccount(1000); // Initial balance
                }
                realAccount.Withdraw(amount);
            }
            else
            {
                Console.WriteLine("Authentication failed. Withdrawal not allowed.");
            }
        }


    }
}

