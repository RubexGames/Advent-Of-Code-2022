// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<List<string>> list = new List<List<string>>();
int score = 0;

for (int i = 0; i < 100; i++)
{

    string input = Console.ReadLine();
    string input2 = Console.ReadLine();
    string input3 = Console.ReadLine();
    List<string> sublist = new List<string>();
    sublist.Add(input);
    sublist.Add(input2);
    sublist.Add(input3);
    list.Add(sublist);
}

foreach(List<string> input in list)
{
    char c = findDouble(input);
    int index;
    if (Char.IsUpper(c))
        index = char.ToUpper(c) - 38;
    else
        index = c - 96;
    //Console.WriteLine(index);
    score += index;
}

char findDouble(List<string> input)
{
    string input1 = input[0];
    string input2 = input[1];
    string input3 = input[2];

    foreach (char c in input1)
    {
        foreach(char c2 in input2)
        {
            foreach (char c3 in input3)
            {
                if (c == c2 && c == c3)
                    return c;
            }
        }
    }
    return 'a';
}

Console.WriteLine(score);
Console.ReadLine();