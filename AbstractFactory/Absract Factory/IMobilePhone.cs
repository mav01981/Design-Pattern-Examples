
/// <summary>  
/// The 'AbstractFactory' interface.  
/// </summary>  
public interface IMobilePhone
{
    ISmartPhone GetSmartPhone();
    INormalPhone GetNormalPhone();
}
