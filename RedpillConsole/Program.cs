using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Redpill;

namespace RedpillConsole
{
    class Program
    {
        private static List<KeyValuePair<int, long>> _list;

        static void Main(string[] args)
        {
            _list = new List<KeyValuePair<int, long>>();
            while (true)
            {
                var random = new Random();
                var n = random.Next(-91, 91);
                var result = ReadifyFactory.GetFibonacciNumber(n);
                _list.Add(new KeyValuePair<int, long>(n, result));
                Console.WriteLine("Index {0}, Result: {1}", n, result);
                Thread.Sleep(100);

                var stream = new MemoryStream();
                var array = new byte[10000];
                stream.Write(array, 0, array.Length);
            }
        }
    }
}
