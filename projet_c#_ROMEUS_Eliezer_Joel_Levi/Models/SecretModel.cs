namespace projet_c__ROMEUS_Eliezer_Joel_Levi.Models;

public sealed class SecretModel
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string Notes { get; set; } = string.Empty;
    public string photo {  get; set; } = string.Empty;
}
