using PracticeWeb.DTOs;
using PracticeWeb.Models;

namespace PracticeWeb.Services
{
    public interface IStudentService
    {
        List<StudentDto> GetAllStudents();

        StudentDto? GetStudentById(int id);

        StudentDto AddStudent(CreateStudentDto studentDto);

        StudentDto? UpdateStudent(int id, UpdateStudentDto studentDto);

        bool DeleteStudent(int id);
    }
}
