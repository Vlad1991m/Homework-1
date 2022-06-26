int num1, num2, num3, Max;
Console.WriteLine("Input the first number: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the second number: ");
num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the third number: ");
num3 = Convert.ToInt32(Console.ReadLine());
if(num1>=num2)
{
Max=num1;
}    
else
{
Max=num2;
} 
if(num3>Max)
{
Max=num3;
}
Console.WriteLine("Max is " + Max);

