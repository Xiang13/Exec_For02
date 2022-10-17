using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// 等腰星行三角形
			int rows = 5;
			for (int i = 0; i <= rows; i++)
			{
				int countOfEmpty = rows - i;
				int countOfStar = i * 2 + 1;
				string row = new string(' ', countOfEmpty) + new string('*', countOfStar);
				Console.WriteLine(row);
			}
		}
	}
}
