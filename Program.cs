using System;
using StudentSystem.Utils;

namespace StudentSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentFileLoader.CSVFileParser("students.csv");
        }
    }
}
