using System;

namespace Strategy
{
    public class EnglishDuck : IQauckbehaviour
    {
        public string Quack()
        {
            return $"Quak Quak English duck";
        }
    }
}
