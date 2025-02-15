using Day_01_G01;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var oddNum = list.Where(n => n % 2 == 1); //1 3 5 7 9
            list.AddRange([11, 12, 13, 14, 15]);
            foreach (var item in oddNum)
            {
                Console.WriteLine(item);
            }*/

            #region Restriction Operators
            //1.Find all products that are out of stock.
            var result01 = ListGenerator.ProductList.Where(p => p.UnitsInStock == 0);
            foreach(var item in result01)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("////////");
            //2. Find all products that are in stock and cost more than 3.00 per unit.
            var result02 = ListGenerator.ProductList.Where(p => p.UnitPrice > 3);
            foreach(var item in result02)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("////////");
            //3. Returns digits whose name is shorter than their value.
            string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var result03 = from str in Arr
            //               let number = Array.IndexOf(Arr, str)
            //               where str.Length < number
            //               select str;
            var result03 = Arr.Where((name, index) => name.Length < index);
            foreach (var item in result03)
            {
                Console.WriteLine(item);
            }
            #endregion
        }
    }
}
