namespace Application.Contracts.Admin;

public interface IAdminService
{
    bool Authenticate(string password);
}