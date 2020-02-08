using StudentSystem.StudentSearcherUtils.Filters;
using StudentSystem.StudentSearcherUtils.Sorters;
using System.Collections.Generic;
using StudentSystem.Models;

namespace StudentSystem
{
    public class StudentSearcher
    {
        private Filterer filterer;
        private Sorter sorter;
        public StudentSearcher()
        {
            filterer = new Filterer();
            sorter = new Sorter();
        }
        public List<Student> FilterByName(List<Student> students,string name)
        {
            List<Student> s = filterer.Filter(new FilterByName(name), students);
            sorter.Sort(new SortAlphabetically(), s);
            return s;
        }
    }
}