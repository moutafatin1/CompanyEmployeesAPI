
namespace Contracts;

public interface IRepositoryManager
{

    ICompanyRepository CompanyRepository { get; }
    IEmployeeRepository EmployeeRepository { get; }
    Task SaveAsync();
}
