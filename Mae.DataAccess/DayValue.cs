using System.ComponentModel.DataAnnotations.Schema;

namespace Mae.DataAccess;

[Table("day_values")]
public class DayValue
{
    public Guid Id { get; set; }
    
    public DateOnly Date { get; set; }
    
    public Decimal Amount { get; set; }
    
    public string? Comment { get; set; }
}