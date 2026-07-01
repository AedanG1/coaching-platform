namespace CoachingPlatform.Models.Entities;

public class Post
{
    public long Id { get; set; }
    public DateTimeOffset CreatedAt { get; set; }

    // User FK
    public long UserId { get; set; }
    public User User { get; set; }

    // Discipline FK
    public long DisciplineId { get; set; }
    public Discipline Discipline { get; set; }

    // Training Block FK
    public long TrainingBlockId { get; set; }
    public TrainingBlock TrainingBlock { get; set; }

    // Self reference FK
    public long? ParentPostId { get; set; }
    public Post? ParentPost { get; set; }

    // enums
    public PostType Type { get; set; }
    public PostModerationStatus? ModerationStatus { get; set; }

    public string Title { get; set; }
    public string Message { get; set; }
    public bool? IsAnswered { get; set; }
}
