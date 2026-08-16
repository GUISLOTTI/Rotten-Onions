namespace RottenOnions.Domain.Entities;

public class Serie
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int? Rating { get; set; }
    public SerieStatus Status { get; set; }
    public DateTime? ReleaseDate { get; set; }
    public DateTime? DateToWatch { get; set; }
    public DateTime CreatedAt { get; set; }
    public List<Comment> Comments = new List<Comment>();
    
}
