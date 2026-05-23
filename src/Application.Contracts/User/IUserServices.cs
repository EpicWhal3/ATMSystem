namespace Application.Contracts.User;

public interface IUserServices
{
    public UserOperationResult GetBalance();

    public UserOperationResult MoneyChange(double amount);

    public UserOperationResult UserOperationHistory();

    public UserCreationResult CreateUser(string name, string pinCode);

    public void Logout();
}
