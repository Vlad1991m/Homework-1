Console.Write("Input a number: ");
int N = Convert.ToInt32(Console.ReadLine());
int current = 1;
if(N<=1)
Console.WriteLine("Input number is invalid, use one starting from number 1");
while (current <= N)
{
    if (current % 2 == 0)
    {
        Console.Write(current + " ");
        current++;
    }
    current++;
} 


