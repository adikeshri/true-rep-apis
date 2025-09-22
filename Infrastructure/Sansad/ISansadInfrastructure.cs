
using TrueRepApis.Domain.ValueObjects;
using TrueRepApis.Infrastructure.Sansad.Models;

namespace TrueRepApis.Infrastructure.Sansad;

public interface ISansadInfrastructure
{
    Task<List<StateDto>> GetStates();
}