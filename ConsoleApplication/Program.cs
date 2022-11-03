using MainClassLibrary;

Shape triangle1 = new Triangle(1, 2, 3);
Shape circle1 = new Circle(5);
triangle1.GetInfo();
Console.WriteLine(triangle1.GetArea());
circle1.GetInfo();
Console.WriteLine(circle1.GetArea());