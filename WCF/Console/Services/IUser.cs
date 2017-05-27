using System.ServiceModel;

namespace Services
{
    [ServiceContract]
    public interface IUser
    {
        [OperationContract]
        string ShowName(string name);
    }
}