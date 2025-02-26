namespace OOP.Encapsulation
{
    public class BankAccount
    {
        private decimal _balance; // Private field

        public void Deposit(decimal amount)
        {
            if (amount > 0)
                _balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= _balance)
                _balance -= amount;
        }

        public decimal GetBalance()
        {
            return _balance;
        }
    }
}
