namespace Library.Geometry
{
    public class Triangle : IFigure
    {
        private double a;
        private double b;
        private double c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double GetArea()
        {
            // ��������, �������� �� ����������� �������������
            if (IsRightTriangle())
            {
                Console.WriteLine("����������� �������� �������������.");
            }

            // ���������� ������������� ������������
            double p = (a + b + c) / 2;

            // ���������� ������� ������������ �� ������� ������
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public bool IsRightTriangle()
        {
            double[] sides = new double[] { a, b, c };
            Array.Sort(sides);

            bool pythagoreanTheorem = sides[0] * sides[0] + sides[1] * sides[1] == sides[2] * sides[2];

            return pythagoreanTheorem;
        }
    }
}
