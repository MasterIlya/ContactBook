using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace ContactBook.Services.Models
{
    public class ContactModel
    {
        public int ContactId { get; set; }
        [Required(ErrorMessage = "Name not specified")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "The length of the name must be from 2 to 30 characters")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Mobile phone not specified")]
        [Phone(ErrorMessage = "Incorrect phone number")]
        [StringLength(13, MinimumLength = 2, ErrorMessage = "The length of the mobile phone number must be from 2 to 13 characters")]
        public string MobilePhone { get; set; }
        [Required(ErrorMessage = "Job title not specified")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "The length of the job title must be from 2 to 50 characters")]
        public string JobTitle { get; set; }
        [Required(ErrorMessage = "Birth date not specified")]
        public DateTime BirthDate { get; set; }
    }
}
