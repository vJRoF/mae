using Mae.DataAccess.Abstractions;

namespace Mae.DataAccess.Implementations;

public class DayValueRepository : IDayValueRepository
{
    private readonly AppDbContext _appDbContext;

    public DayValueRepository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }
    
    public DayValue[] GetDayValues()
    {
        return _appDbContext.DayValues.ToArray();
    }
}