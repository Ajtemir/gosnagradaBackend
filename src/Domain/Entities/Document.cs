using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

public class Document
{
    [Key]
    public int Id { get; set; }
    [JsonIgnore]
    public byte[]? Bytes { get; set; }
    public string? Name { get; set; }
    [ForeignKey(nameof(DocumentType))]
    public int DocumentTypeId { get; set; }
    public DocumentType DocumentType { get; set; } = null!;
    public string? Extension => Path.GetExtension(this.Name)?.Remove(0);
    public string? ContentType => Extension is null ? null : $"application/${Extension}";
    public ChildDocument ChildDocument { get; set; } = null!;
    public ApplicationDocument ApplicationDocument { get; set; } = null!;
    public void Reset()
    {
        this.Bytes = null;
        this.Name = null;
    }
}