using System.Collections.Generic;
using StudentSystem.Models;
using System;

namespace StudentSystem
{
    class StudentStorage
    {
        
    }

    public class StudentDataManager
    {
        StudentStorage studentStorage;

        public StudentDataManager()
        {
            studentStorage = new StudentStorage();
        }        

        public Student StoreStudent(Student student)
        {
            return null;
        }
        public void DeleteStudent(int studentId)
        {
            
        }

        public List<Student> FindStudentsByName(string name)
        {
            return null;
        }

        public List<Student> FindByType(string type)
        {
            return null;
        }

        public List <Student> FindByGender(string gender)
        {
            return null;
        }
    }
}