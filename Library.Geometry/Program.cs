namespace Library.Geometry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var geometryServices = new Services();

            geometryServices.AddFigure(new Circle(5));
            geometryServices.AddFigure(new Triangle(3, 4, 5));

            geometryServices.CalculateAreas();
        }
    }
}