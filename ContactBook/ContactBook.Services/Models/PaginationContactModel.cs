using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBook.Services.Models
{
    public class PaginationContactModel
    { 
        public List<ContactModel> Contacts { get; set; }
        public int CountOfPages { get; set; }
        public int CurrentPage { get; set; }
    }
}
