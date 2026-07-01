namespace CoachingPlatform.Models.Entities;

public class User
{
    public long Id { get; set; }
    public DateTimeOffset CreatedAt { get; set; }

    public bool Admin { get; set; }
    public string Name { get; set; }
    public string Auth { get; set; }
}
