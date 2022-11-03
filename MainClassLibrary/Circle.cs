namespace MainClassLibrary
{
    public class Circle : Shape
    {
        private readonly string NewName = "Круг";
        private double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
        public override void GetInfo()
        {
            Console.WriteLine(
               $"\nНазвание фигуры: {NewName} " +
               $"\nРадиус: {Radius}" +
               $"\nПлощадь: {GetArea()}");
        }
    }
}
