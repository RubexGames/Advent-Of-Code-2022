// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
List<int> Calories = new List<int>();

int food = 0;
for (int i = 0; i < 2244; i++)
{
    string input = Console.ReadLine();
    if (input == "")
    {
        Calories.Add(food);
        food = 0;
    }
    else
    {
        food += Convert.ToInt32(input);
    }
}
int mostFood = 0;
int secondMostFood = 0;
int thirthMostFood = 0;
foreach (int n in Calories)
{
    if (n > mostFood)
    {
        thirthMostFood = secondMostFood;
        secondMostFood = mostFood;
        mostFood = n;
    }
    else if(n > secondMostFood)
    {
        thirthMostFood = secondMostFood;
        secondMostFood = n;

    }
    else if (n > thirthMostFood)
    {
        thirthMostFood = n;
    }
}
Console.WriteLine(mostFood + secondMostFood + thirthMostFood);
Console.WriteLine(mostFood);
Console.WriteLine(secondMostFood);
Console.WriteLine(thirthMostFood);