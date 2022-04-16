// See https://aka.ms/new-console-template for more information
using BuilderPatterns;

Console.WriteLine("Hello, World!");

IBuilder builder = new MacBuilder("I5处理器", "三星125");//2
ComputerDirector director = new ComputerDirector(builder);//1
director.makeComputer(builder);//3
Computer macComputer = builder.getComputer();//4
Console.WriteLine("mac computer:" + macComputer.toString());

IBuilder lenovoBuilder = new LenovoBuilder("I7处理器", "海力士222");
director.makeComputer(lenovoBuilder);
Computer lenovoComputer = lenovoBuilder.getComputer();
Console.WriteLine("lenovo computer:" + lenovoComputer.toString());
//Console.ReadLine();

