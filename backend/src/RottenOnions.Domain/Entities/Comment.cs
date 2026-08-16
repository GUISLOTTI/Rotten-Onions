namespace RottenOnions.Domain.Entities;

public class Comment
{
    public int Id { get; set; }
    public string Text { get; set; }
    public DateTime CreateAt { get; set; }

    public int? MovieId { get; set; }
    public Movie Movie { get; set; }
    public int? SerieId { get; set; }
    public Serie Serie { get; set; }
}
