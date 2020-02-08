using StudentSystem.Models;
using System.Collections.Generic;
using StudentSystem.StudentSearcherUtils.Sorters;

namespace StudentSystem.StudentSearcherUtils.Sorters
{
    public class Sorter
    {
        public List<Student> Sort(ISorter sorter, List<Student> students)
        {
            return sorter.Sort(students);
        }
    }
}