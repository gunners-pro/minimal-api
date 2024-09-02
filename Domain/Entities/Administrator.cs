namespace minimal_api.Domain.Entities;

public class Administrator
{
    public int Id { get; set; }
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string Profile { get; set; } = string.Empty;

}
