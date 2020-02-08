using StudentSystem.Models;
using System.Collections.Generic;
using System.Linq;

namespace StudentSystem.StudentSearcherUtils.Sorters
{
    public class SortAlphabetically : ISorter
    {
        public List<Student> Sort(List<Student> students)
        {
            return students.OrderBy(s => s.Name).ToList();
        }
    }
}