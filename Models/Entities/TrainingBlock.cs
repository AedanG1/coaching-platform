namespace CoachingPlatform.Models.Entities;

public class TrainingBlock
{
    public long Id { get; set; }
    public DateTimeOffset CreatedAt { get; set; }

    // User FK
    public long UserId { get; set; }
    public User User { get; set; }

    // Discipline FK
    public long DisciplineId { get; set; }
    public Discipline Discipline { get; set; }

    // Class collection
    public ICollection<Class> Classes { get; set; }

    public string Title { get; set; }
    public DateOnly StartDate { get; set; }
    public DateOnly? EndDate { get; set; }
}
