using System.ComponentModel.DataAnnotations.Schema;
using Domain.Common;

namespace Domain.Entities;

/// <summary>
/// Candidate for government reward.
/// </summary>
public abstract class Candidate : BaseAuditableEntity
{
    [ForeignKey(nameof(CandidateTypeNavigation))]
    public string CandidateType { get; set; } = null!;
    public CandidateType CandidateTypeNavigation { get; set; } = null!;
    
    public byte[]? Image { get; set; }
    public string? ImageName { get; set; }
    public int MemberId { get; set; }
    public Member Member { get; set; } = null!;
    public string? Pin => Member.Pin;
    
    public ApplicationUser? CreatedByUser { get; set; }
    public ApplicationUser? ModifiedByUser { get; set; }
    public ICollection<RewardApplication> Applications { get; set; } = new List<RewardApplication>();
}