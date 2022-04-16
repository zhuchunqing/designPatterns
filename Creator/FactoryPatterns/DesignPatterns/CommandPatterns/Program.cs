using CommandPatterns;

Receiver receiver = new Receiver();
ICommand cmd = new ConcreteCommand(receiver);
Invoker ir = new Invoker(cmd);
Console.WriteLine("客户访问调用者的call()方法...");
ir.call();
