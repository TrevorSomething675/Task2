namespace MainClassLibrary
{
    //Я решил использовать абстрактный класс, а не интерфес потому что объекты однотипные
    abstract public class Shape
    {
        internal string? Name;
        public virtual double GetArea()//Получение площади
        {
            return -1;
        }
        public virtual void GetInfo() { }//Получение информации о фигуре
    }
}
