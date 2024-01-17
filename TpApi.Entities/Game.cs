using TpApi.Entities.Common;

namespace TpApi.Entities;

public class Game : Entity, IDated
{
    public Game(string name)
    {
        Id = Guid.NewGuid();
        Name = name;
    }

    public Game()
    {
    }

    public string Name { get; set; } = null!;

    public User? User { get; set; } = null!;
    public Guid? UserId { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
