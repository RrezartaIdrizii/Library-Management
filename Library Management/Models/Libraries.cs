using System.Collections.Generic;
namespace Library_Management.Models
{
    public class Libraries
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Users> Students { get; set; }
        //public List<User> Users { get; set; }
    }
}
