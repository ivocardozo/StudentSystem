using System.Collections.Generic;
using StudentSystem.Models;
using System.IO;

namespace StudentSystem.Utils
{
    public static class StudentFileLoader
    {
        public static List<Student> CSVFileParser(string path)
        {
            List<Student> students = new List<Student>();
            var reader = new StreamReader(File.OpenRead(path));
            while(!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                Student s = CSVLineParser(line);
                students.Add(s);
            }

            return students;
        }
        private static Student CSVLineParser(string CSVLine)
        {
            var values = CSVLine.Split(','); //type, Name, Gender, lastUpdate
            Student s = new Student(){
                Type = values[0],
                Name = values[1],
                Gender = values[2],
                LastUpdated = values[3]
            };

            return s;
        }
    }
}