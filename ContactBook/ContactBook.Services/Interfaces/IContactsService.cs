using ContactBook.Services.Mappers;
using ContactBook.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBook.Services.Interfaces
{
    public interface IContactsService
    {
        public Task CreateAsync(ContactModel model);
        public Task DeleteContactAsync(int id);
        public Task<GeneralContactModel> GetContactsAsync(int currentPage);
        public Task<ContactModel> GetContactAsync(int id);
        public Task UpdateAsync(ContactModel contactModel);
    }
}
