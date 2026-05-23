namespace Application.Contracts.Admin;

public interface IAdminLoginService
{
    public AdminLoginResult Login(string password);
}
