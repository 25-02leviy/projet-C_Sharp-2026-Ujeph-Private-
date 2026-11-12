using projet_c__ROMEUS_Eliezer_Joel_Levi.Data;
using projet_c__ROMEUS_Eliezer_Joel_Levi.Models;

namespace projet_c__ROMEUS_Eliezer_Joel_Levi.Repositories;

public sealed class ActivityRepository
{
    private readonly AppData data;
    public ActivityRepository(AppData data) => this.data = data;
    public async Task<List<ActivityModel>> AllAsync(int userId) => (await data.GetActivitiesAsync(userId)).Select(x => new ActivityModel { Id = x.Id, UserId = userId, Date = x.Date, Title = x.Title, Description = x.Description, Status = x.Status }).ToList();
    public Task SaveAsync(int userId, ActivityModel model) => data.SaveActivityAsync(userId, new ActivityRecord(model.Id, model.Date, model.Title, model.Description, model.Status));
    public Task DeleteAsync(int userId, int id) => data.DeleteAsync("activities", userId, id);
}
