using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryPattern
{
    public static class FactoryModelClient
    {
        /// <summary>
        /// 如果要换类(数据库),只需要把new ACEO()换成 new ADiaosi(),
        /// 此时由于多态的关系，使得声明IFactory接口的对象factory事先根本
        /// 不知道是在访问哪个类(数据库),却可以在运行时很好地完成工作，这就
        /// 是所谓的业务逻辑（表白）与数据库（人）的解耦。
        /// </summary>
        /// <param name="factory"></param>
        public static void Invoke(IFactory factory)
        {
            //工厂方法模式是定义一个用于创建对象的接口，让子类决定实例化哪一个类
            //IFactory factory = new Diaosi();
            IConfession confession = factory.CreateConfession();
            confession.AskForDinner();
            confession.GoForAWalk();
            confession.HandInHand();
            confession.Kiss();
        }
    }
}
