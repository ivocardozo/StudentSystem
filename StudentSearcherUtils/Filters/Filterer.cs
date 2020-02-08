using System.Collections.Generic;
using StudentSystem.Models;


namespace StudentSystem.StudentSearcherUtils.Filters
{
    public class Filterer
    {
        public List<Student> Filter(IFilter filter, List<Student> students)
        {
            var result = new List<Student>();
            foreach(var s in students)
            {
                if (filter.Evaluate(s))
                {
                    result.Add(s);
                }
            }
            return result;
        }
    }
}