using System;

class BankTerminal
{
    public Action<int> OnMoneyWithdraw;

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
            Console.WriteLine($"Повідомлення: знято {amount} грн");
        
        terminal.OnMoneyWithdraw = null;
        
        terminal.OnMoneyWithdraw?.Invoke(77777);

        terminal.Withdraw(500);
    }
}