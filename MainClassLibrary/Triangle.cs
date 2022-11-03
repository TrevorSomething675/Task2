namespace MainClassLibrary
{
    public class Triangle : Shape
    {
        //Создание конструктора класса Triangle и методов для расчёты его площади и вывода информации
        private readonly string NewName = "Треугольник";
        private bool Rtriangle = false;
        private double Side1 { get; set; }
        private double Side2 { get; set; }
        private double Side3 { get; set; }
        public Triangle(double side1, double side2, double side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
            if (((side1*side1) == (side2*side2)+(side3*side3)) || (side2*side2==(side1*side1)+(side3*side3)) || (side3*side3)==(side1*side1)+(side2*side2))//Проверка на прямоугольный треугольник
                Rtriangle = true;
        }
        public override double GetArea()
        {
            double P = Side1 + Side2 + Side3 / 2;
            return Math.Sqrt(
                P * (P - Side1) * (P - Side2) * (P - Side3)
                );
        }
        public override void GetInfo()
        {
            Console.WriteLine(
                $"\nНазвание фигуры: {NewName} " +
                $"\nСтороны: {Side1}, {Side2}, {Side3}" +
                $"\nПлощадь: {GetArea()}" +
                $"\nТреугольник прямоугольный? - {Rtriangle}");
        }
    }
}
