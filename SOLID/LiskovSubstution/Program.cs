// See https://aka.ms/new-console-template for more information
using LiskovSubstution;

Console.WriteLine("Hello, World!");

//Rectangle rectangle = new Rectangle();
//Square square = new Square();

//rectangle.Width = 10;
//rectangle.Height = 5;
//Console.WriteLine(rectangle.GetArea());
//square.Width = 5;
//Console.WriteLine(square.GetArea());

var rectangle = Geometry.GetRectangle(5,9);
//rectangle.Width = 5;
//rectangle.Height = 10;

Console.WriteLine(rectangle.GetArea());