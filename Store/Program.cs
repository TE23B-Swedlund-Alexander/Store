bool success = false;
bool leave = false;
int ageNum = 0;
Random rnd = new Random();
int money = rnd.Next(50, 100);

while (success != true)
{
    Console.WriteLine("age?");
    string age = Console.ReadLine();
    success = int.TryParse(age, out ageNum);

    if (success == false)
    {
        Console.WriteLine("write a number idiot");
    }
}
if (ageNum > 18)
{
    Console.WriteLine("welcome");
}
if (ageNum <= 18)
{
    Console.WriteLine("LEEEEAAAVEE!!! >:(");
}

while (money > 0 && ageNum > 18)
{
    Console.WriteLine($"you have {money} monies");
    Console.WriteLine("what do you want to buy");
    Console.WriteLine("candy 5 mony,chips 25 mony or soda 10 mony or maybe you want a silencer for 500 monies");
    string purchase = Console.ReadLine();
    if (purchase == "candy")
    {
        money = money - 5;
        Console.WriteLine("you have more candy now :D");

    }
    if (purchase == "chips")
    {
        money = money - 25;
        Console.WriteLine("you have more chips now :D");

    }
    if (purchase == "soda")
    {
        money = money - 10;
        Console.WriteLine("you have more soda now :D");

    }
    if (purchase == "silencer")
    {
        money = money - 500;
        Console.WriteLine("you have a fucking silencer now :O");

    }
    if (purchase == "wanna bet")
    {

        Console.WriteLine("sure heads or tails");
        string coin = Console.ReadLine();
        int flip = rnd.Next(1, 2);
        if (flip == 1 && coin == "heads")
        {
            Console.WriteLine("you win");
            money = money + money;
        }
        else if (flip == 2 && coin == "tails")
        {
            Console.WriteLine("you win");
            money = money + money;
        }
        else
        {
            Console.WriteLine("you lose");
            money = 0;
        }
    }

}

Console.WriteLine("it was nice having you, bye");

Console.ReadLine();