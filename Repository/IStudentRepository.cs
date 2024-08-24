using StudentAdminPortalAPI.Models;

namespace StudentAdminPortalAPI.Repository
{
    public interface IStudentRepository
    {
        List<Student> GetAllStudents();
        Task<List<Student>> GetAllStudentsAsync();
    }
}
