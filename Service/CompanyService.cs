


using AutoMapper;
using Entities.Exceptions;
using Entities.Models;
using Shared.DataTransferObjects;

namespace Service;

internal sealed class CompanyService : ICompanyService
{
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;
    private readonly IMapper _mapper;

    public CompanyService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
    {
        _repository = repository;
        _logger = logger;
        _mapper = mapper;
    }

    public IEnumerable<CompanyDto> GetAllCompanies(bool trackChanges)
    {

        var companies = _repository.CompanyRepository.GetAllCompanies(trackChanges);
        var companiesDto = _mapper.Map<IEnumerable<CompanyDto>>(companies);

        //var companiesDto = companies.Select(c => new CompanyDto(c.Id, c.Name ?? "", string.Join(' ', c.Address, c.Country))).ToList();
        return companiesDto;



    }

    public CompanyDto GetCompany(Guid companyId, bool trackChanges)
    {
        var company = _repository.CompanyRepository.GetCompany(companyId, trackChanges);

        if (company is null)
        {
            throw new CompanyNotFoundException(companyId);
        }
        var companyDto = _mapper.Map<CompanyDto>(company);
        return companyDto;
    }

    public CompanyDto CreateCompany(CompanyForCreationDto company)
    {
        var companyEntity = _mapper.Map<Company>(company);
        _repository.CompanyRepository.CreateCompany(companyEntity);
        _repository.Save();
        var companyToReturn = _mapper.Map<CompanyDto>(companyEntity);
        return companyToReturn;
    }
}

