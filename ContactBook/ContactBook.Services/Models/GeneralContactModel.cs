using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBook.Services.Models
{
    public class GeneralContactModel
    {
        public PaginationContactModel PaginationModel { get; set; }
        public ContactModel Contact { get; set; }
    }
}
