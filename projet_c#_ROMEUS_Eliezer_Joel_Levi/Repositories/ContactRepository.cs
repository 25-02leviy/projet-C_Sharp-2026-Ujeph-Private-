using projet_c__ROMEUS_Eliezer_Joel_Levi.Data;
using projet_c__ROMEUS_Eliezer_Joel_Levi.Models;

namespace projet_c__ROMEUS_Eliezer_Joel_Levi.Repositories;

public sealed class ContactRepository
{
    private readonly AppData data;
    public ContactRepository(AppData data) => this.data = data;
    public async Task<List<ContactModel>> AllAsync(int userId) => (await data.GetContactsAsync(userId)).Select(x => new ContactModel { Id = x.Id, UserId = userId, FirstName = x.FirstName, LastName = x.LastName, Phone = x.Phone, Email = x.Email, Notes = x.Notes }).ToList();
    public Task SaveAsync(int userId, ContactModel model) => data.SaveContactAsync(userId, new ContactRecord(model.Id, model.FirstName, model.LastName, model.Phone, model.Email, model.Notes));
    public Task DeleteAsync(int userId, int id) => data.DeleteAsync("contacts", userId, id);
}
