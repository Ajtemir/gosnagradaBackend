using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Index(nameof(Pin), IsUnique = true)]
public class Member
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string? Pin { get; set; }
    public PinAbsenceReason? PinAbsenceReason { get; set; }
    public ICollection<Candidate> Candidates { get; set; } = new List<Candidate>();
}