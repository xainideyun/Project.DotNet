namespace _11_抽象工厂模式
{
    public interface IFactory
    {
        IUser GetUser();
        IDepartment GeDepartment();
    }
}