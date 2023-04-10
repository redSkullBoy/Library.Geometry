namespace Library.Geometry
{
    public class Services
    {
        private List<IFigure> figures = new List<IFigure>();

        public void AddFigure(IFigure figure)
        {
            figures.Add(figure);
        }

        public void CalculateAreas()
        {
            foreach (IFigure figure in figures)
            {
                double area = figure.GetArea();
                Console.WriteLine($"Площадь фигуры: {area}");
            }
        }
    }
}
