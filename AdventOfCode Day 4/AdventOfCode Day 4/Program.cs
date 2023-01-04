// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int score = 0;
for (int i = 0; i < 1000; i++)
{
    string[] input = Console.ReadLine().Split(',');
    string[] input1 = input[0].Split('-');
    string[] input2 = input[1].Split('-');
    int begin1 = int.Parse(input1[0]);
    int eind1 = int.Parse(input1[1]);
    int begin2 = int.Parse(input2[0]);
    int eind2 = int.Parse(input2[1]);

    if (begin1 <= begin2 && eind1 >= begin2 || begin2 <= begin1 && eind2 >= begin1)
        score++;
    //if (eind1 - begin1 > eind2 - begin2)
    //{
    //    if (begin1 <= begin2 && eind1 >= eind2)
    //        score++;
    //}
    //else
    //{
    //    if (begin1 >= begin2 && eind1 <= eind2)
    //        score++;
    //}
}

Console.WriteLine(score);