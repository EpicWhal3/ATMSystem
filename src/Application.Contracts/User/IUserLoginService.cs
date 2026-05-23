namespace Application.Contracts.User;

public interface IUserLoginService
{
    UserLoginResult Login(string name, string passCode);
}