namespace CoachingPlatform.Models.Entities;

public class ClassVideo
{
    public long Id { get; set; }
    public DateTimeOffset CreatedAt { get; set; }

    // Class FK
    public long ClassId { get; set; }
    public Class Class { get; set; }
    // Video FK
    public long VideoId { get; set; }
    public Video Video { get; set; }
}
