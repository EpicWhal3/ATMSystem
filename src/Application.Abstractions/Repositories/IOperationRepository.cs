using Application.Models;

namespace Application.Abstractions.Repositories;

public interface IOperationRepository
{
    IEnumerable<Operation> GetAllOperations(long accountId);
}