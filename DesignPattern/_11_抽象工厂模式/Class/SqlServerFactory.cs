namespace _11_抽象工厂模式.Class
{
    public class SqlServerFactory : IFactory
    {
        public IUser GetUser()
        {
            return new SqlServerUser();
        }

        public IDepartment GeDepartment()
        {
            return new SqlServerDepartment();
        }
    }
}