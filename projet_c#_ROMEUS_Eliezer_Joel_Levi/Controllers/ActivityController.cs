using projet_c__ROMEUS_Eliezer_Joel_Levi.Data;
using projet_c__ROMEUS_Eliezer_Joel_Levi.Models;
using projet_c__ROMEUS_Eliezer_Joel_Levi.Repositories;

namespace projet_c__ROMEUS_Eliezer_Joel_Levi.Controllers;

public sealed class ActivityController
{
    private readonly ActivityRepository repository;
    public ActivityController(AppData data) => repository = new ActivityRepository(data);
    public Task<List<ActivityModel>> AllAsync(int userId) => repository.AllAsync(userId);
    public Task SaveAsync(int userId, ActivityModel model) => repository.SaveAsync(userId, model);
    public Task DeleteAsync(int userId, int id) => repository.DeleteAsync(userId, id);
}
