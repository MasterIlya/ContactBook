using ContactBook.Repositories.Interfaces;
using ContactBook.Repositories.Items;
using Microsoft.EntityFrameworkCore;

namespace ContactBook.Repositories.Repositories
{
    public class ContactsRepository : BaseRepository<ContactItem>, IContactsRepository
    {
        public ContactsRepository(IRepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public async Task<List<ContactItem>> GetAsync(int skip, int take)
        {
            return await GetItems()
                .OrderBy(x => x.ContactId)
                .Skip(skip)
                .Take(take)
                .ToListAsync();
        }

        public async Task<int> GetCountAsync()
        {
            return await GetItems().CountAsync();
        }

    }
}

