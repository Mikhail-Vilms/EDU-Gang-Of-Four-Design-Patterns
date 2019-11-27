namespace Gang_Of_Four_Design_Patterns.CreationalPatterns.Factory
{
    /// <summary>
    /// Provides implementation of the IBankCard interface.
    /// </summary>
    public class CreditCard : IBankCard
    {
        private float _balance;
        private float _limit;
        private float _cashBackRate;

        public CreditCard(float balance, float limit, float cashBackRate)
        {
            _balance = balance;
            _limit = limit;
            _cashBackRate = cashBackRate;
        }

        public float CheckBalance()
        {
            return _balance;
        }

        public void Deposit(float amount)
        {
            _balance += amount;
            System.Console.WriteLine($"Deposit: {amount}$. Balance: {_balance}$");
        }

        public void Purchase(float price)
        {
            Withdraw(price*(1 -_cashBackRate));
            System.Console.WriteLine($"Purchase: {price}. Cashback: {_cashBackRate}");
        }

        public void Withdraw(float amount)
        {
            if (_limit > _balance - amount) 
            {
                System.Console.WriteLine($"Unsuccessful attempt to withdraw {amount}$ from credit card." + 
                    $"Current balance for this card: {_balance}" +
                    $"Limit for this credit card: {_limit}");
                return;
            }
            _balance -= amount;
            System.Console.WriteLine($"{amount}$ has been withdrawn. Balance: {_balance}$");
        }
    }
}
