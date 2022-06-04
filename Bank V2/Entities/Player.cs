namespace BankV2.Entities;
public class Player
{
    public string Name { get; }
    public decimal Money { get; }

    public Player(string name)
    {
        Name = name;
        Money = 0;
    }
}