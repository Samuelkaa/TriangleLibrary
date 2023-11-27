namespace TriangleLibrary
{
	public class Triangle
	{
		public void CheckTypeOfTriangle(int a, int b, int c)
		{
			int sqa = (int)Math.Pow(a, 2);
			int sqb = (int)Math.Pow(b, 2);
			int sqc = (int)Math.Pow(c, 2);

			if (a + b <= c || a + c <= b || b + c <= a)
			{
				Console.WriteLine("Такого треугольника не существует");
			}
			else
			{
				if (sqa + sqb == sqc || sqa + sqc == sqb || sqb + sqc == sqa)
				{
					Console.WriteLine("Треугольник прямоугольный");
				}
				else if (sqa < sqb + sqc || sqb < sqa + sqc || sqc < sqa + sqb)
				{
					Console.WriteLine("Треугольник остроугольный");
				}
				else
				{
					Console.WriteLine("Треугольник тупоугольный");
				}
			}
		}
	}
}