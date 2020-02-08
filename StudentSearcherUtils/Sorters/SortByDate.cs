using StudentSystem.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace StudentSystem.StudentSearcherUtils.Sorters
{
    public class SortByDate : ISorter
    {
        public List<Student> Sort(List<Student> students)
        {
            return students.OrderBy(s => long.Parse(s.LastUpdated)).ToList();
        }
    }
}