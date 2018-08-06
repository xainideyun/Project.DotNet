using _11_抽象工厂模式.Models;

namespace _11_抽象工厂模式
{
    public interface IDepartment : IModelOperation<Department>
    {
        string GetCode(string id);
    }
}