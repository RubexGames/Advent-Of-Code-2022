// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int score = 0;
for (int i = 0; i < 2500; i++)
{
    string[] input = Console.ReadLine().Split();
    if (input[1] == "X")
    {
        if (input[0] == "A")
        {
            score += 3;
        }
        if (input[0] == "B")
        {
            score += 1;
        }
        else if (input[0] == "C")
        {
            score += 2;
        }
    }
    else if (input[1] == "Y")
    {
        score += 3;
        if (input[0] == "A")
        {
            score += 1;
        }
        else if (input[0] == "B")
        {
            score += 2;
        }
        else if (input[0] == "C")
        {
            score += 3;
        }
    }
    else if (input[1] == "Z")
    {
        score += 6;
        if (input[0] == "A")
        {
            score += 2;
        }
        else if (input[0] == "B")
        {
            score += 3;
        }
        else if (input[0] == "C")
        {
            score += 1;
        }
    }
}
Console.WriteLine(score);

//Rock 1
//Paper 2
//Scissor 3