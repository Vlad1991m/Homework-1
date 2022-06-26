int num1, num2;
Console.WriteLine("Input the first number: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the second number: ");
num2 = Convert.ToInt32(Console.ReadLine());
if(num1>num2)
{
   Console.WriteLine("Max = " + num1); 
}
else if(num1==num2)
{
    Console.WriteLine("Numbers are equal");
}
else
{
    Console.WriteLine("Max = " + num2);
}
    
