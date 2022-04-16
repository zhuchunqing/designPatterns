// See https://aka.ms/new-console-template for more information
using DecoratorPatterns;

Console.WriteLine("Hello, World!");
Decorator decorator = new Decorator();
ConcreteComponent c = new ConcreteComponent();
ConcreteDecoratorA d1 = new ConcreteDecoratorA();
ConcreteDecoratorA d2 = new ConcreteDecoratorA();
decorator.SetComponent(c);
d1.SetComponent(c);
d2.Operation();
