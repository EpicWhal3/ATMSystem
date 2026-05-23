using Application.Abstractions.Models;
using Application.Models;

namespace Application.Abstractions.Repositories;

public interface IUserRepository
{
    public void AddUser(string name, string pinCode);

    public User? GetUser(string name, string pinCode);

    public DataBaseOperationResults MoneyExchange(User user, double amount);
}