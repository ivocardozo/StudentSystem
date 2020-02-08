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
            List<Student> studentsFiltered = new List<Student>();
            foreach(SearchCriteria sc in inputCommands.GetSearchCriteriaItems())
            {
                switch(sc.Criteria)
                {
                    case "name":                        
                        List<Student> students = studentDataManager.FindStudentsByName(sc.Value);
                        PrintStudents(students);
                        break;
                    case "type":
                        studentDataManager.FindByType(sc.Value);
                        break;
                    case "gender":
                        studentDataManager.FindByGender(sc.Value);
                        break;
                    default:
                        break;
                }
            }
        }

        private void PrintStudents(List<Student> students)
        {
            foreach(Student s in students)
            {
                Console.WriteLine($"Type: {s.Type}");
                Console.WriteLine($"Name: {s.Name}");
                Console.WriteLine($"Gender: {s.Gender}");
                Console.WriteLine($"LastUpdate: {s.LastUpdated}");
            }
        }

    }
}