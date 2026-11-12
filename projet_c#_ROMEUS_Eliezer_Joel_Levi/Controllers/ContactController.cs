using projet_c__ROMEUS_Eliezer_Joel_Levi.Data;
using projet_c__ROMEUS_Eliezer_Joel_Levi.Models;
using projet_c__ROMEUS_Eliezer_Joel_Levi.Repositories;

namespace projet_c__ROMEUS_Eliezer_Joel_Levi.Controllers;

public sealed class ContactController
{
    private readonly ContactRepository repository;
    public ContactController(AppData data) => repository = new ContactRepository(data);
    public Task<List<ContactModel>> AllAsync(int userId) => repository.AllAsync(userId);
    public Task SaveAsync(int userId, ContactModel model) => repository.SaveAsync(userId, model);
    public Task DeleteAsync(int userId, int id) => repository.DeleteAsync(userId, id);
}
