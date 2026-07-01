namespace CoachingPlatform.Models.Entities;

public class Session
{
    public long Id { get; set; }
    public DateTimeOffset CreatedAt { get; set; }

    // User FK
    public long UserId { get; set; }
    public User User { get; set; }

    // Discipline FK
    public long? DisciplineId { get; set; }
    public Discipline? Discipline { get; set; }

    public SessionType Type { get; set; }

    public string? Title { get; set; }
    public DateOnly Date { get; set; }
}
