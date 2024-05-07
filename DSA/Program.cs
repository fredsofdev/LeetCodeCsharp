// See https://aka.ms/new-console-template for more information
using DSA.Week1;
using DSA.Week1.Assignment;
using DSA.Week2.Assignment;
using DSA.Week2.Queue;
using DSA.Week2.Sort;
using DSA.Week2.Stack;
using DSA.Week3.Assignment;
/*
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

}*/

/*Console.WriteLine("Percolation");
Console.Write("Enter N: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{N}x{N} Grid is Created");

IPercolation percolation = new Percolation(N);
Random rnd = new Random();
while (true)
{
    int row = rnd.Next(0, N);
    int col = rnd.Next(0, N);
    Console.Write($"Open:row,col [{row}][{col}]");

    percolation.open(row, col);
    bool isPercolates = percolation.percolates();
    Console.WriteLine($"{percolation.numberOfOpenSites()} out of {N * N}");
    Console.WriteLine($"Is Percolates: {isPercolates}");
    if (isPercolates) break;
}
Console.ReadLine();
*/

//StackClient.RunWithMax(); 
//RandomizedQueue<int>.Run();
//Shellsort.SortTest();
//Shuffle.ShuffleTest();
//MergingWithHalfAux.Run();
//CountingInversiont.Run();
ShuffleLinkedList.Run();
//QueueClient.Run();