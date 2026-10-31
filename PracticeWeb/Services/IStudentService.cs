using PracticeWeb.DTOs;
using PracticeWeb.Models;

namespace PracticeWeb.Services
{
    public interface IStudentService
    {
        Task<List<StudentDto>> GetAllStudentsAsync();

        Task<StudentDto?> GetStudentByIdAsync(int id);

        Task<StudentDto> AddStudentAsync(CreateStudentDto studentDto);

        Task<StudentDto?> UpdateStudentAsync(int id, UpdateStudentDto studentDto);

        Task<bool> DeleteStudentAsync(int id);

        Task<bool> EmailExistsAsync(string email, int? excludeStudentId = null);
        Task<List<StudentDto>> SearchStudentsByNameAsync(string search);
        Task<List<StudentDto>> GetStudentsByDepartmentIdAsync(int departmentId);
    }
}
