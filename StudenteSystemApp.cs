using System.Collections.Generic;
using StudentSystem.Models;
using StudentSystem.Utils;

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

    }
}