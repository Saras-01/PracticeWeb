using PracticeWeb.Models;
using PracticeWeb.Models;

namespace PracticeWeb.Repositories;

public interface IStudentRepository
{
    Task<List<Student>> GetAllAsync();

    Task<Student?> GetByIdAsync(int id);

    Task<bool> EmailExistsAsync(
        string email,
        int? excludeStudentId = null);

    Task AddAsync(Student student);

    Task UpdateAsync(Student student);

    Task DeleteAsync(Student student);
    Task<List<Student>> SearchByNameAsync(string search);
    Task<List<Student>> GetByDepartmentIdAsync(int departmentId);

}