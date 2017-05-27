namespace Services
{
    public class User : IUser
    {
        public string ShowName(string name)
        {
            return $"我的名字是：{name}";
        }
    }
}