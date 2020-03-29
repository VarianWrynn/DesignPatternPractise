using DesignPattern.FactoryPattern;
using System;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            FactoryModelClient.Invoke(new LeeWang());
            Console.WriteLine("==============无情分割线===================");
            FactoryModelClient.Invoke(new XuShuChun());
        }
    }
}
