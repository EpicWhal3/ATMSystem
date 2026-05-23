namespace Application.Contracts.Admin;

public interface IAdminService
{
    public bool Authenticate(string password);
}
