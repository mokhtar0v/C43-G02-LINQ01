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
            Console.WriteLine("//////");
            #endregion

            #region Transformation Operators
            //1. Return a sequence of just the names of a list of products.
            var res01 = ListGenerator.ProductList.Select(p => p.ProductName);
            foreach(var item in res01)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("//////");
            //2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
            string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            var res02 = words.SelectMany(word => new[] { word.ToLower(), word.ToUpper() });
            foreach(var item in res02)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("//////");
            //3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
            var res03 = ListGenerator.ProductList.Select(p => $"Name: {p.ProductName}, Price: {p.UnitPrice}");
            foreach(var item in res03)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("//////");
            //4. Determine if the value of ints in an array match their position in the array.
            int[] Ar = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var res04 = Ar.Select((value, flag) => new { num = value, indx = value == flag });
            foreach(var item in res04)
            {
                Console.WriteLine($"{item.num}: {item.indx}");
            }
            Console.WriteLine("//////");
            //5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };
            var res05 = from a in numbersA
                        from b in numbersB
                        where (a < b)
                        select $"{a} is less than {b}";
            foreach(var item in res05)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("//////");
            //6. Select all orders where the order total is less than 500.00.
            var res06 = ListGenerator.CustomerList.SelectMany(c => c.Orders).Where(order => order.Total > 500);
            foreach(var item in res06)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("//////");
            //7. Select all orders where the order was made in 1998 or later.
            var res07 = ListGenerator.CustomerList.SelectMany(c => c.Orders).Where(order => order.OrderDate.Year >= 1998);
            foreach (var item in res07)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("//////");
            #endregion
        }
    }
}
