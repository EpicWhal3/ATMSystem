using Application.Models;

namespace Application.Abstractions.Repositories;

public interface IOperationRepository
{
    public IEnumerable<Operation> GetAllOperations(long accountId);
}