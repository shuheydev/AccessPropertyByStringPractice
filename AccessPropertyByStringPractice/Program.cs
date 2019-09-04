using System;

namespace AccessPropertyByStringPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var myClass = new MyClass();

            int val = myClass["MyProperty3"];

            Console.WriteLine($"MyProperty3：{val + 100}");//出力 -> MyProperty3：30
        }
    }
}
