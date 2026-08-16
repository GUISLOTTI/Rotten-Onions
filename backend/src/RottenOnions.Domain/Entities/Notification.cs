namespace RottenOnions.Domain.Entities;

public class Notification
{
    public string Id { get; set; }
    public Movie Movie { get; set; }
    public int MovieId { get; set; }
    public string Message { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool Read { get; set; }
}
