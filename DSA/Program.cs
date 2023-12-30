// See https://aka.ms/new-console-template for more information
using DSA.Week1;

Console.WriteLine("Unio Find Test");

Console.Write("Enter N: ");
int N = int.Parse(Console.ReadLine()!);

IUF uf = new WQUwithPathCompressionUF(N);

while (true)
{
    Console.Write("Command (u || c): ");
    string command = Console.ReadLine()!;
    if (command != "u" && command != "c") continue;
    Console.Write("p,q: ");
    string[] pair = Console.ReadLine()!.Split(",");
    int p = int.Parse(pair[0]);
    int q = int.Parse(pair[1]);
    if (command == "u")
    {
        uf.union(p, q);
        Console.WriteLine($"union {p}--{q}");
    }
    else if(command == "c")
    {
        if(uf.connected(p, q))
        {
            Console.WriteLine($"{p} and {q} connected");
        }
        else
        {
            Console.WriteLine($"{p} and {q} not connected");
        }
    }

}

