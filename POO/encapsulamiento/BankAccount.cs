namespace OOP_design_patterns.src.OopPrinciples.Encapsulation;
public class BankAccount
{
    private decimal balance;

    public BankAccount(decimal balance)
    {
        Deposit(balance);
    }
    
    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Deposit amount must be positive");
        }

        this.balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0 || amount > balance)
        {
            throw new ArgumentException("Ingresa un monto de retiro válido");
        }

        this.balance -= amount;
    }

    public decimal GetBalance()
    {
        return balance;
    }
}
