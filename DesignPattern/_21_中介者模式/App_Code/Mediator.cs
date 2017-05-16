namespace _21_中介者模式.App_Code
{
    public abstract class Mediator
    {
        public abstract void Send(string msg, Country country);
    }
}