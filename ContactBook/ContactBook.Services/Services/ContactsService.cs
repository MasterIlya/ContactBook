using ContactBook.Repositories.Interfaces;
using ContactBook.Services.Interfaces;
using ContactBook.Services.Mappers;
using ContactBook.Services.Models;

namespace ContactBook.Services.Services
{
    public class ContactsService : IContactsService
    {
        private readonly IContactsRepository _contactsRepository;
        private const int DefaultContactsCount = 10;
        private const int DefaultCurrentPage = 1;

        public ContactsService(IContactsRepository contactsRepository)
        {
            _contactsRepository = contactsRepository;
        }

        public async Task CreateAsync(ContactModel model)
        {
            var item = ContactsMapper.Map(model);

            await _contactsRepository.CreateAsync(item);
        }

        public async Task DeleteContactAsync(int id)
        {
            var item = await _contactsRepository.GetAsync(id);
            await _contactsRepository.RemoveAsync(item);
        }

        public async Task<GeneralContactModel> GetContactsAsync(int currentPage)
        {
            if (currentPage == 0)
            {
                currentPage = DefaultCurrentPage;
            }

            var skip = (currentPage - 1) * DefaultContactsCount;
            var take = DefaultContactsCount;
            var itemsList = await _contactsRepository.GetAsync(skip, take);

            var modelList = itemsList.Select(x => ContactsMapper.Map(x)).ToList();

            var elementsCount = await _contactsRepository.GetCountAsync();

            var countOfPages = Convert.ToInt32(Math.Ceiling((double)elementsCount / take));

            var contacts = ContactsMapper.Map(modelList, countOfPages, currentPage);

            var generalModel = ContactsMapper.Map(contacts);

            return generalModel;
        }

        public async Task<ContactModel> GetContactAsync(int id)
        {
            var item = await _contactsRepository.GetAsync(id);

            var model = ContactsMapper.Map(item);

            return model;
        }

        public async Task UpdateAsync(ContactModel contactModel)
        {
            var item = await _contactsRepository.GetAsync(contactModel.ContactId);

            item.Name = contactModel.Name;
            item.MobilePhone = contactModel.MobilePhone;
            item.BirthDate = contactModel.BirthDate;
            item.JobTitle = contactModel.JobTitle;

            await _contactsRepository.UpdateAsync(item);
        }

    }
}
