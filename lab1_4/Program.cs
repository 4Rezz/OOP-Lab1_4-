using System;

namespace Lab4
{
	class Program
	{
		static void Main(string[] args)
		{
			double x, xp, xk, dx, A, B, y;

			Console.WriteLine("xp = "); xp = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("xk = "); xk = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("dx = "); dx = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("A = "); A = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("B = "); B = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("---------------------------");
			Console.WriteLine("|".PadRight(5) + "x" + "|".PadLeft(5) + "y".PadLeft(5) + "|".PadLeft(5));
			Console.WriteLine("---------------------------");

			x = xp;
			while (x <= xk)
			{
				A = 1 / x + 4;
				if (x < 1)
					B = 0.65 * x + 8;
				else
					if (x >= 5)
					B = Math.Sqrt(1 + Math.Sqrt(x));
				else
					B = Math.Atan((x + 6.1) / 2) + Math.Exp(x);

				y = A - B;

				Console.WriteLine("|".PadRight(5) + x + "|".PadLeft(5) + "".PadLeft(5) + y + " |".PadLeft(5));
				x += dx;
			}
			Console.WriteLine("---------------------------");

		}
	}
}
