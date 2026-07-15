namespace ENSE707_Week1_Lab;

public class  BankAccount
{
    // Property to hold the account holder's name.
    public string AccountHolder { get; set; }
    // Property to hold the current balance of the account. It has a private setter to prevent external modification.
    public decimal Balance { get; private set; }

    // Constructor to initialize the bank account with an account holder's name and an opening balance.
    public BankAccount(string accountHolder, decimal openingBalance)
    {
        if (string.IsNullOrWhiteSpace(accountHolder))
            throw new ArgumentException("Account holder name is required.");

        if(openingBalance < 0)
            throw new ArgumentException("Opening balance cannot be negative.");

        AccountHolder = accountHolder;
        Balance = openingBalance;
    }

    // Method to deposit money into the account.
    public void Deposit(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Deposit amount must be positive.");

        Balance = Balance + amount;
    }

    // Method to withdraw money from the account. Returns true if successful, false if insufficient funds.
    public bool Withdraw(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Withdrawal amount must be positive.");

        if (amount > Balance)
        {
            return false;
        }
        Balance = Balance - amount;
        return true;
    }

    // Method to calculate a 2% transaction fee based on the amount.
    public decimal CalculateTransactionFee(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Transaction amount must be positive.");

        return amount * 0.02m;
    }
}