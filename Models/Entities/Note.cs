namespace CoachingPlatform.Models.Entities;

public class Note
{
    public long Id { get; set; }
    public DateTimeOffset CreatedAt { get; set; }

    // User FK
    public long UserId { get; set; }
    public User User { get; set; }

    // Training Block FK
    public long TrainingBlockId { get; set; }
    public TrainingBlock TrainingBlock { get; set; }

    // Class Note Collection
    public ICollection<ClassNote> ClassNotes { get; set; }

    public string Title { get; set; }
    public string Text { get; set; }
}
