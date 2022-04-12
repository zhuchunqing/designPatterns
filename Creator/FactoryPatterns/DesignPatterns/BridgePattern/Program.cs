// See https://aka.ms/new-console-template for more information
using BridgePattern;

Console.WriteLine("Hello, World!");
//白色
IColor white = new White();
Circle square = new Circle();
//白色的正方形
square.SetColor(white);
square.Draw();

//长方形
AbstractShape rectange = new Rectangle();
rectange.SetColor(white);
rectange.Draw();

Console.ReadLine();