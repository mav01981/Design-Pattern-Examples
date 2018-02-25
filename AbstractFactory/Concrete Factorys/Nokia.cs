
    /// <summary>  
    /// The 'ConcreteFactory1' class.  
    /// </summary>  
    public class Nokia : IMobilePhone
    {
        public ISmartPhone GetSmartPhone()
        {
            return new NokiaPixel();
        }

        public INormalPhone GetNormalPhone()
        {
            return new Nokia1600();
        }
    }
