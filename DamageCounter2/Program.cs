using DamageCounter2;

while (true)
{
    int roll = RollDice();
    SwordDamage swordDamage = new SwordDamage(roll);

    Console.WriteLine("0 - ani magiczny, ani płonący\n1 - magiczny\n2 - płonący\n3magiczny i płonacy\ninne wartości - koniec: ");
    if (Int32.TryParse(Console.ReadKey(false).KeyChar.ToString(), out int number))
    {
        if (number > 3 || number < 0)
            return;

        swordDamage.Magic = number == 1 || number == 3;
        swordDamage.Flaming = number == 2 || number == 3;

        Console.WriteLine($"\nRzut: {swordDamage.Roll}. Zadane obrażenia: {swordDamage.Damage}.\n");
    }
    else
    {
        return;
    }
}

static int RollDice()
{
    Random random = new Random();
    int roll = 0;
    for (int i = 0; i < 3; i++)
    {
        roll += random.Next(1, 7);
    }

    return roll;
}