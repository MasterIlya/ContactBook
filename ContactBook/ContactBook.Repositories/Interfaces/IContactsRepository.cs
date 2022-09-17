using ContactBook.Repositories.Items;

namespace ContactBook.Repositories.Interfaces
{
    public interface IContactsRepository
    {
        public Task<ContactItem> GetAsync(int id);
        public Task CreateAsync(ContactItem item);
        public Task RemoveAsync(ContactItem item);
        public Task UpdateAsync(ContactItem item);
        public Task<List<ContactItem>> GetAsync(int skip, int take);
        public Task<int> GetCountAsync();
    }
}
