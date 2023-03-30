Console.Write("Enter number : ");
int num = int.Parse(Console.ReadLine());

for(int i = 1; i <= num; i++)
{
    Console.WriteLine($"{i} -> {Math.Pow(i,3)}" );
}