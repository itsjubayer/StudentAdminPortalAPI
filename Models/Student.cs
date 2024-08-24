namespace StudentAdminPortalAPI.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; } = DateTime.Now;
        public string Email { get; set; }
        public string Contact { get; set; }
        public string ProfileImage { get; set; }
        public int GenderId { get; set; }
        public Gender Gender { get; set; }
        public Address Address { get; set; }

    }
}
