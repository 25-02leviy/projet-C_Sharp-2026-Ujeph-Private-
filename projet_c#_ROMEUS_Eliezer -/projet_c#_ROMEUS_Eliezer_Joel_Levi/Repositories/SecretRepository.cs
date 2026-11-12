using projet_c__ROMEUS_Eliezer_Joel_Levi.Data;
using projet_c__ROMEUS_Eliezer_Joel_Levi.Models;

namespace projet_c__ROMEUS_Eliezer_Joel_Levi.Repositories;

public sealed class SecretRepository
{
    private readonly AppData data;
    public SecretRepository(AppData data) => this.data = data;

    public async Task<List<SecretModel>> AllAsync(int userId) => (await data.GetSecretsAsync(userId)).Select(x => new SecretModel { Id = x.Id, UserId = userId, Title = x.Title, Username = x.Username, Password = x.Password, Notes = x.Notes }).ToList();
    public Task SaveAsync(int userId, SecretModel model) => data.SaveSecretAsync(userId, new SecretRecord(model.Id, model.Title, model.Username, model.Password, model.Notes));
    public Task DeleteAsync(int userId, int id) => data.DeleteAsync("secrets", userId, id);
}
