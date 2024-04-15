using JWTToken.Model;

namespace JWTToken.Repository.Interface
{
    public interface IUserRepository
    {
        bool CheckUserExist(UserModel userModel);
    }
}
