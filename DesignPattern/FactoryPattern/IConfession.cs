using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryPattern
{
    /// <summary>
    /// 业务逻辑（表白的方法)
    /// </summary>
    public interface IConfession
    {
        public virtual void AskForDinner()
        {
            
        }

        public virtual void GoForAWalk()
        {
            
        }

        public virtual void HandInHand()
        {
           
        }

        public virtual void Kiss()
        {
           
        }
    }

    /// <summary>
    /// CEO实现业务逻辑（表白的方式）
    /// </summary>
    public class CEOExpress:IConfession
    {
        public virtual void AskForDinner()
        {
            Console.WriteLine("来，吃了这顿价值5万元的饭");
        }

        public virtual void GoForAWalk()
        {
            Console.WriteLine("坐我的保驰捷兜兜风");
        }

        public virtual void HandInHand()
        {
            Console.WriteLine("今天开始，你必须做我的女友");
        }

        public virtual void Kiss()
        {
            Console.WriteLine("壁咚");
        }
    }

    /// <summary>
    /// 屌丝实现业务逻辑（表白的方式）
    /// </summary>
    public class DiaosiExpress:IConfession
    {
        public virtual void AskForDinner()
        {
            Console.WriteLine("在吗？哦，等你洗完澡一起吃个饭吧");
        }

        public virtual void GoForAWalk()
        {
            Console.WriteLine("女神，可以一起去散步吗？");
        }

        public virtual void HandInHand()
        {
            Console.WriteLine("好想牵女神的手啊，可是又怕收到好人卡");
        }

        public virtual void Kiss()
        {
            Console.WriteLine("内心里YY一样亲吻女神的感觉");
        }
    }
}
