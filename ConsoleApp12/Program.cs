using System;

class BankTerminal
{
    public event Action<int> OnMoneyWithdraw;

    public void Withdraw(int amount)
    {
        Console.WriteLine($"Знято {amount} грн");
        OnMoneyWithdraw?.Invoke(amount);
    }
}

class Program
{
    static void Main()
    {
        BankTerminal terminal = new BankTerminal();

        terminal.OnMoneyWithdraw += amount =>
            Console.WriteLine($"Логування: знято {amount} грн");
        
        terminal.OnMoneyWithdraw = null;      
        terminal.OnMoneyWithdraw?.Invoke(500); 

        terminal.Withdraw(500);
    }
}