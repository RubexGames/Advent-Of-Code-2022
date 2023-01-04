// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Stack<string>[] stack = new Stack<string>[9];

for (int i = 0; i < 9; i++)
{
    stack[i] = new Stack<string>();
    string input = Console.ReadLine();
    while (input != "next")
    {
        stack[i].Push(input);
        input = Console.ReadLine();
    }
}

for (int i = 0; i < 502; i++)
{
    string[] input = Console.ReadLine().Split();
    Move(int.Parse(input[1]), int.Parse(input[3]) - 1, int.Parse(input[5]) -1);
}

foreach(Stack<string> s in stack)
{
    Console.WriteLine(s.Peek());
}


void Move(int amount, int from, int to)
{
    Stack<string> interStack = new Stack<string>();
    for (int i = 0; i < amount; i++)
        interStack.Push(stack[from].Pop());

    for (int i = 0; i < amount; i++)
        stack[to].Push(interStack.Pop());
}