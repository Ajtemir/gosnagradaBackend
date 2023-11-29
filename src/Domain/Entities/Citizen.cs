using Domain.Dictionary;

namespace Domain.Entities;

public class Citizen  : Person
{
    public required string? Pin { get; set; }
    public required string? PassportNumber { get; set; }
    public required string RegisteredAddress { get; set; }
    public string? ActualAddress { get; set; }
    
    public int EducationId { get; set; }
    public Education? Education { get; set; }
    public string? ScienceDegree { get; set; }
    
    public int YearsOfWorkTotal { get; set; }
    public int YearsOfWorkInIndustry { get; set; }
    public int YearsOfWorkInCollective { get; set; }
}