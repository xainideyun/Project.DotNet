namespace _11_抽象工厂模式.Class
{
    public class OracleFactory : IFactory
    {
        public IUser GetUser()
        {
            return new OracleUser();
        }

        public IDepartment GeDepartment()
        {
            return new OracleDepartment();
        }
    }
}