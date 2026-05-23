namespace Application.Contracts.User;

public interface IUserLoginService
{
    public UserLoginResult Login(string name, string passCode);
}
