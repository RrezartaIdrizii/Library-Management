using System.ComponentModel.DataAnnotations.Schema;

namespace Library_Management.Models
{
    public class Users
    {
        public int Id { get; set; } //    
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public string PhoneNumber { get; set; }
        public int Role { get; set; }

        public int? LibrariesId { get; set; }
       [ForeignKey("LibrariesId ")]
        public Libraries Libraries { get; set; }

    }
}
