using ContactBook.Repositories.Items;
using ContactBook.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBook.Services.Mappers
{
    public class ContactsMapper
    {
        public static ContactItem Map(ContactModel model)
        {
            if (model == null)
            {
                return null;
            }
            return new ContactItem
            {
                Name = model.Name,
                MobilePhone = model.MobilePhone,
                JobTitle = model.JobTitle,
                BirthDate = model.BirthDate
            };
        }

        public static ContactModel Map(ContactItem item)
        {
            return new ContactModel
            {
                ContactId = item.ContactId,
                Name = item.Name,
                BirthDate = item.BirthDate,
                JobTitle = item.JobTitle,
                MobilePhone = item.MobilePhone
            };
        }

        public static PaginationContactModel Map(List<ContactModel> contacts, int countOfPages, int currentPage)
        {
            return new PaginationContactModel
            {
                Contacts = contacts,
                CountOfPages = countOfPages,
                CurrentPage = currentPage
            };
        }

        public static GeneralContactModel Map(PaginationContactModel paginationModel)
        {
            return new GeneralContactModel
            {
                PaginationModel = paginationModel
            };
        }
    }
}
