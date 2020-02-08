using System.Collections.Generic;
using StudentSystem.Models;

namespace StudentSystem
{
    public interface ISorter
    {
        List<Student> Sort(List<Student> students);
    }
}