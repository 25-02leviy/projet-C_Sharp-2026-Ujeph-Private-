namespace projet_c__ROMEUS_Eliezer_Joel_Levi.Models;

public sealed class ActivityModel
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public DateTime Date { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Status { get; set; } = "À faire";
}
