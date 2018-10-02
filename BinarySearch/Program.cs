using System;


namespace BinarySearch
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] testData = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37,
		41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };

			Search(59, testData);
		}

		static void Search(int searchTerm, int[] list)
		{
			int min = 0;
			int max = list.Length - 1;
			int candidate = (max + min) / 2;

			while (list[candidate] != searchTerm)
			{
				if (list[candidate] < searchTerm)
				{
					min = candidate + 1;
				}
				else
				{
					max = candidate - 1;
				}

				candidate = (min + max) / 2;

				if (max < min)
				{
					Console.WriteLine("Search Term not present in List");
					return;
				}
			}

			Console.WriteLine("Found search term at index {0}", candidate);
	
		}
	}
}
