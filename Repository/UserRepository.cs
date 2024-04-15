using JWTToken.Model;
using JWTToken.Repository.Interface;
using Microsoft.AspNetCore.Connections;
using System.Data;

namespace JWTToken.Repository
{
    public class UserRepository : IUserRepository
    {
        public bool CheckUserExist(UserModel userModel) => (userModel.UserName == "DebugTutorial" && userModel.Password == "DebugTutorial@123");
    }
}
