using MainClassLibrary;

Shape triangle1 = new Triangle(1, 2, 3);
Shape circle1 = new Circle(5);
Shape triangle2 = new Triangle(3,4,5);
triangle1.GetInfo();
Console.WriteLine(triangle1.GetArea());
circle1.GetInfo();
Console.WriteLine(circle1.GetArea());
triangle2.GetInfo();
Console.WriteLine(triangle2.GetArea());