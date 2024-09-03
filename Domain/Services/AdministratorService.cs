using minimal_api.Domain.DTOs;
using minimal_api.Domain.Entities;
using minimal_api.Domain.Interfaces;
using minimal_api.Infrastructure.Database;

namespace minimal_api.Domain.Services;

public class AdministratorService(AppDbContext dbContext) : IAdministratorService
{
    private readonly AppDbContext _dbContext = dbContext;

    public Administrator? Login(LoginDTO loginDTO)
    {
        var admin = _dbContext.Administrators.Where(a => a.Email == loginDTO.Email && a.Password == loginDTO.Password).FirstOrDefault();
        return admin;
    }
}
