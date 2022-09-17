using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ContactBook.Repositories.Items
{
    [Table("Contacts")]
    public class ContactItem
    {
        [Key]
        public virtual int ContactId { get; set; }
        public virtual string Name { get; set; }
        public virtual string MobilePhone { get; set; }
        public virtual string JobTitle { get; set; }
        public virtual DateTime BirthDate { get; set; }
    }
}
