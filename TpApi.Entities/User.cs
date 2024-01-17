using TpApi.Entities.Common;

namespace TpApi.Entities;

public class User : Entity, IDated
{
    public User(string firstName, string lastName, string email)
    {
        Id = Guid.NewGuid();
        FirstName = firstName;
        LastName = lastName;
        Email = email;
    }

    public User()
    {
    }

    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;

    public List<Game> Games { get; set; } = [];

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}