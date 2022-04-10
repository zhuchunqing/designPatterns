// See https://aka.ms/new-console-template for more information
using FactoryPatterns;

Console.WriteLine("Hello, World!");
Operation oper = null;
oper = OperationFactory.createOperation("+");
oper.NumberA = 2;
oper.NumberB = 3;
double result=oper.GetResult();
Console.WriteLine(result);
Console.ReadLine();
Console.WriteLine("hello world");
Console.ReadLine();

  
