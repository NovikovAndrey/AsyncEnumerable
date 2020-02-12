using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsyncEnumerable
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Repository repo = new Repository();
            IAsyncEnumerable<string> data = repo.GetDataAsync();
            await foreach(var name in data)
            {
                Console.WriteLine(name);
            }
        }
    }
}
