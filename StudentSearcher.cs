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
        public List<Student> FilterByType(List<Student> students, string type)
        {
            List<Student> s = filterer.Filter(new FilterByType(type), students);
            sorter.Sort(new SortByDate(), s);
            return s;
        }
        public List<Student> FilterByGender(List<Student> students, string gender)
        {
            List<Student> s = filterer.Filter(new FilterByGender(gender), students);
            sorter.Sort(new SortByDate(), s);
            return s;
        }
    }
}