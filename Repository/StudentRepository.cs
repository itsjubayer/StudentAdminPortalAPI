using Microsoft.EntityFrameworkCore;
using StudentAdminPortalAPI.Data;
using StudentAdminPortalAPI.Models;

namespace StudentAdminPortalAPI.Repository
{
    public class StudentRepository : IStudentRepository   
    {
        private readonly ApplicationDbContext _context;
        public StudentRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<Student> GetAllStudents()
        {
            return _context.Students.ToList();
        }

        public async Task<List<Student>> GetAllStudentsAsync()
        {
            return await _context.Students.Include(nameof(Gender))
                 .ToListAsync();
        }
    }
}
