namespace _21_中介者模式.App_Code
{
    public abstract class Country
    {
        protected Mediator Mediator;

        protected Country(Mediator mediator)
        {
            Mediator = mediator;
        }

        public void Send(string msg)
        {
            Mediator.Send(msg, this);
        }
        public abstract void Notify(string msg);
    }
}