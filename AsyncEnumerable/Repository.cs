using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsyncEnumerable
{
    internal class Repository
    {
        string[] data = {"Tom", "Sam", "Kate", "Alice", "Bob" };

        internal async IAsyncEnumerable<string> GetDataAsync()
        {
            for (int i=0; i<data.Length; i++)
            {
                Console.WriteLine($"Get{i+1}");
                await Task.Delay(1000);
                yield return data[i];
            }
        }
    }
}