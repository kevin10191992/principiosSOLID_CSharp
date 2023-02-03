using DependencyInversion;

namespace Api.Tests
{
    public interface IStudentRepository
    {
        public IEnumerable<Student> GetAll();
        public void Add(Student student);
    }
}