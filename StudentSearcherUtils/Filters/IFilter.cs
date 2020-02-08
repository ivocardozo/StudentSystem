using StudentSystem.Models;

namespace StudentSystem.StudentSearcherUtils.Filters
{
    public interface IFilter
    {
        public bool Evaluate(Student s);
    }
}