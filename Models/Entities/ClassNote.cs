namespace CoachingPlatform.Models.Entities;

public class ClassNote
{
    public long Id { get; set; }
    public DateTimeOffset CreatedAt { get; set; }

    // Class FK
    public long ClassId { get; set; }
    public Class Class { get; set; }
    // Video FK
    public long NoteId { get; set; }
    public Note Note { get; set; }
}
