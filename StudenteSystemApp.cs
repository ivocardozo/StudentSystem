using System.Collections.Generic;
using StudentSystem.Models;
using StudentSystem.Utils;
using System;

namespace StudentSystem
{
    public class StudentSystemApp
    {
        private StudentDataManager studentDataManager;
        private InputCommandParser inputCommands;
        
        public StudentSystemApp(string[] args)
        {
            studentDataManager = new StudentDataManager();
            inputCommands = new InputCommandParser(args);
        }
        public void Run()
        {
            RegisterStudentsFromFile();
            ExecuteCommands();
        }

        private void RegisterStudentsFromFile()
        {
            List<Student> students = StudentFileLoader.CSVFileParser(inputCommands.GetFilePath());
            RegisterStudents(students);
        }
        
        private void RegisterStudents(List<Student> students)
        {
            foreach(Student s in students)
            {
                studentDataManager.StoreStudent(s);
            }
        }

        private void ExecuteCommands()
        {
            List<Student> studentsFiltered = studentDataManager.GetStudents();
            foreach(SearchCriteria sc in inputCommands.GetSearchCriteriaItems())
            {
                switch(sc.Criteria)
                {
                    case "name":                        
                        List<Student> students = studentDataManager.FilterByName(studentsFiltered, sc.Value);
                        PrintStudents(students);
                        break;
                    case "type":
                        studentDataManager.FilterByType(studentsFiltered, sc.Value);
                        break;
                    case "gender":
                        studentDataManager.FilterByGender(studentsFiltered, sc.Value);
                        break;
                    default:
                        break;
                }
            }
        }

        private void PrintStudents(List<Student> students)
        {
            Console.WriteLine(students.Count > 0 ? "" : "No students found");
            foreach(Student s in students)
            {
                Console.WriteLine($"Type: {s.Type}");
                Console.WriteLine($"Name: {s.Name}");
                Console.WriteLine($"Gender: {s.Gender}");
                Console.WriteLine($"LastUpdate: {s.LastUpdated}");
                Console.WriteLine("-------------------");
            }
            Console.WriteLine();
        }

    }
}