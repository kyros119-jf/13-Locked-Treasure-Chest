
using System.Security.Cryptography.X509Certificates;

public class TreasureChest
{
    private int gold;


public void AddGold(int amount)
{
    if(amount > 0)
    gold += amount;
    Console.WriteLine($"Gold added: {amount}");

    }

    public void RemoveGold(int amount)
    {
        if (amount <= gold)
        {
            gold -= amount;
            Console.WriteLine($"Gold removed: {amount}");

        }
        else
        {
            Console.WriteLine("Cannot remove more gold than the chest contains.");
        }
    }
public int ViewGold()
{
    return gold;
}
  }