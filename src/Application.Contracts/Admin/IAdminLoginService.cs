namespace Application.Contracts.Admin;

public interface IAdminLoginService
{
    AdminLoginResult Login(string password);
}