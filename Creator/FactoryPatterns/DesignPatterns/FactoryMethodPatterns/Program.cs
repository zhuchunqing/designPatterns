using FactoryMethodPatterns;

Console.WriteLine("hello world");
IFactory  eg = new eggesFactory();
eg.footFactory().GetFood();