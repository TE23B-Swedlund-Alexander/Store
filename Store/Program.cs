bool success = false;
int ageNum = 0;
Random rnd = new Random();
int money = rnd.Next(50,500);
Console.WriteLine($"you have {money} coins");
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
if (ageNum > 12)
{
    Console.WriteLine("welcome");
}
if (ageNum <= 12)
{
    Console.WriteLine("LEEEEAAAVEE!!! >:(");
}

while (money>0 && ageNum > 12)
{
Console.WriteLine("roulette, dice or coin flip (answer a, b or c)");
string game = Console.ReadLine();

}



Console.ReadLine();