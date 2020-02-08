using StudentSystem.Models;

namespace StudentSystem.StudentSearcherUtils.Filters
{
    public class FilterByGender : IFilter
    {
        private string gender;
        public FilterByGender(string gender)
        {
            this.gender = gender;
        }
        public bool Evaluate(Student s)
        {
            return s.Gender == gender[0].ToString().ToUpper();
        }
    }
}
