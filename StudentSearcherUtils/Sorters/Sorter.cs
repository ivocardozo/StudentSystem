using StudentSystem.Models;
using System.Collections.Generic;
using StudentSystem.StudentSearcherUtils.Sorters;

namespace StudentSystem.StudentSearcherUtils.Sorters
{
    public class Sorter
    {
        public List<Student> Sort(ISorter sorter, List<Student> students)
        {
            List<Student> sortedList = new List<Student>();
            return sorter.Sort(students);
        }
    }
}