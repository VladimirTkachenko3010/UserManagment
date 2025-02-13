using System.Collections.Generic;
using System.ServiceModel;

namespace UserService
{
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        List<UserDto> GetUsers();

        [OperationContract]
        void AddUser(UserDto userDto);

        [OperationContract]
        void UpdateUser(UserDto userDto);
    }
}
