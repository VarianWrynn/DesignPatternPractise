using DesignPattern.FactoryPattern;
using System;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory factory = new LeeWang();
            IConfession confession = factory.CreateConfession();
            confession.AskForDinner();
            confession.GoForAWalk();
            confession.HandInHand();
            confession.Kiss();

        }
    }
}
