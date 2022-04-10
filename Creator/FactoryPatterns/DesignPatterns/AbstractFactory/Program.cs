// See https://aka.ms/new-console-template for more information
using AbstractFactory;

Console.WriteLine("Hello, World!");
AbstractFactoryAB factory = new ConcreteFactory1();
factory.CreateProductB().GetProductB();
Console.ReadLine();