namespace Slot_Machine;

public class GameEngine : IGameEngine
{
    public int GameBalance { get; set; }
    
    public GameEngine()
    {
    }
    
    public void DepositAccount()
    {
        Console.WriteLine("Enter deposit amount - ");
        var deposit = int.Parse(Console.ReadLine() ?? string.Empty);
        GameBalance = deposit;
        Console.WriteLine($"Your deposit amount {GameBalance}");
    }

    public void Play()
    {
        while (GameBalance > 0)
        {
            Console.WriteLine("Enter stake amount:");
            var stakeAmount = Console.ReadLine();
            
        }
    }
}