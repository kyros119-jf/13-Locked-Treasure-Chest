TreasureChest chest = new TreasureChest();
chest.AddGold(100);
chest.RemoveGold(20);
chest.RemoveGold(40);
;


Console.WriteLine($"Current gold: { chest.ViewGold()}");