
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ExploreVS
{
    class Program
    {
        public static async void Main(string[] args)
        {
            var numbers = GetNumbersAsync();
            await foreach(var n in GetSumOfNums(numbers))
            {
                Console.WriteLine(n);
            }
            Console.ReadKey();
        }
        public static IEnumerable<int> GetNumbersAsync()
        {
            List<int> a = new List<int>();
            a.Add(1);
            a.Add(2);
            a.Add(3);
            a.Add(4);
            return a;
        }
        public static async IAsyncEnumerable<int> GetSumOfNums(IAsyncEnumerable<int> nums)
        {
            var sum = 0;
            await foreach(var num in nums)
            {
                sum += num;
                yield return sum;
            }
        }
        
    }
}