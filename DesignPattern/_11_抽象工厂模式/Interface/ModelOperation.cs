using _11_抽象工厂模式.Models;

namespace _11_抽象工厂模式
{
    public interface IModelOperation<in T> where T : new()
    {
        void Insert(T user);
        void Update(T user);
        void Delete(T user);
        void Delete(string id);
    }
}