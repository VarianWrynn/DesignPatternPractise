using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryPattern
{
    /// <summary>
    /// 执行业务逻辑的人(数据库)
    /// </summary>
    public interface IFactory
    {
        IConfession CreateConfession();
    }

    public class LeeWang : IFactory
    {
        public LeeWang()
        {
            Console.WriteLine("我是王力");
        }
        public IConfession CreateConfession()
        {
            return new CEOExpress();
        }
    }

    public class XuShuChun : IFactory
    {
        public XuShuChun()
        {
            Console.WriteLine("我是许书春");
        }
        public IConfession CreateConfession()
        {
            return new DiaosiExpress();
        }
    }
}
