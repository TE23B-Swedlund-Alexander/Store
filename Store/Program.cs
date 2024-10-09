bool success = false;

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
    Console.WriteLine("how many");
string howMany = Console.ReadLine();
int purchaseAmount = 0;
 int.TryParse(howMany, out purchaseAmount);
    if (purchase == "candy" && money >= 5*purchaseAmount)
    {

        money = money - 5*purchaseAmount;
        Console.WriteLine("you have more candy now :D");

    }
   else if (purchase == "chips" && money >= 25*purchaseAmount)
    {
        money = money - 25*purchaseAmount;
        Console.WriteLine("you have more chips now :D");

    }
    else if (purchase == "soda" && money >= 10*purchaseAmount)
    {
        money = money - 10*purchaseAmount;
        Console.WriteLine("you have more soda now :D");

    }
   else if (purchase == "silencer" && money >= 500*purchaseAmount)
    {
        money = money - 500*purchaseAmount;
        Console.WriteLine("you have a fucking silencer now :O");

    }
    else if (purchase == "wanna bet")
    {

        Console.WriteLine("sure heads or tails");
        string coin = Console.ReadLine();
        int flip = rnd.Next(1, 2);
        if (flip == 1 && coin == "heads")
        {
            Console.WriteLine("you win");
            money = money + money*purchaseAmount;
        }
        else if (flip == 2 && coin == "tails")
        {
            Console.WriteLine("you win");
            money = money + money*purchaseAmount;
        }
        else
        {
            Console.WriteLine("you lose");
            money = 0;
        }
    }
    else{
        Console.WriteLine("you can not afford that");
    }
    Console.WriteLine("do you want to continue your shopping");
    string leave = Console.ReadLine();
    if (leave == "no")
    {
ageNum = 3;
    }
    Console.WriteLine();
}

Console.WriteLine("it was nice having you, bye");

Console.ReadLine();