using StudentSystem.Models;

namespace StudentSystem.StudentSearcherUtils.Filters
{
    public class FilterByType : IFilter
    {
        private string type;
        public FilterByType(string type)
        {
            this.type = type;
        }
        public bool Evaluate(Student s)
        {
            return s.Type == type;
        }
    }
}