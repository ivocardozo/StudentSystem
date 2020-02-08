using StudentSystem.Models;

namespace StudentSystem.StudentSearcherUtils.Filters
{
    public class FilterByName : IFilter
    {
        private string name;
        public FilterByName(string name)
        {
            this.name = name;
        }
        public bool Evaluate(Student s)
        {
            return s.Name == name;
        }
    }
}