using ContactBook.Services.Interfaces;
using ContactBook.Services.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContactBook.Controllers
{
    public class ContactsController : Controller
    {
        private readonly IContactsService _contactsService;

        public ContactsController(IContactsService contactsService)
        {
            _contactsService = contactsService;
        }

        [HttpGet]
        public async Task<IActionResult> GetContacts(int currentPage)
        {
            var contacts = await _contactsService.GetContactsAsync(currentPage);

            return View("Contacts", contacts);
        }

        [HttpPost]
        public async Task<IActionResult> AddContact(ContactModel model)
        {

            if (ModelState.IsValid)
            {
                await _contactsService.CreateAsync(model);

                return RedirectToAction("GetContacts");
            }
            else
            {
                string answer = "Ok";
                return Json(answer);
            }
        }

        [HttpPost]
        public async Task<IActionResult> DeleteContact(int id)
        {
            await _contactsService.DeleteContactAsync(id);

            return RedirectToAction("GetContacts");
        }

        [HttpGet]
        public async Task<IActionResult> GetContactForEdit(int id)
        {
            var contact = await _contactsService.GetContactAsync(id);

            return Json(contact);

        }

        [HttpPost]
        public async Task<IActionResult> EditContact(ContactModel model)
        {

            if (ModelState.IsValid)
            {
                await _contactsService.UpdateAsync(model);

                return RedirectToAction("GetContacts");
            }
            else
            {
                string answer = "Ok";
                return Json(answer);
            }
        }
    }
}
