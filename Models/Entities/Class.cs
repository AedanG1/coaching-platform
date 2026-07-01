namespace CoachingPlatform.Models.Entities;

public class Class
{
    public long Id { get; set; }
    public DateTimeOffset CreatedAt { get; set; }

    // Training Block FK
    public long TrainingBlockId { get; set; }
    public TrainingBlock TrainingBlock { get; set; }

    // Class Video Collection
    public ICollection<ClassVideo> ClassVideos { get; set; }
    // Class Note Collection
    public ICollection<ClassNote> ClassNotes { get; set; }

    public string Title { get; set; }
    public int Position { get; set; }
    public DateOnly? CompletedDate { get; set; }
}
