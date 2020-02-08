using System.Collections.Generic;
using StudentSystem.Models;
using System;

namespace StudentSystem
{
    class StudentStorage
    {
        int id;
        List<Student> students;
        public StudentStorage()
        {
            id = 1;
            students = new List<Student>();
        }
        public Student Add(Student student)
        {
            student.Id = id;
            student.LastUpdated = DateTime.Now.ToString();
            students.Add(student);
            id ++;
            return StudentCloner(student);
        }
        Student StudentCloner(Student student)
        {
            return new Student(){
                    Id = student.Id,
                    Gender = student.Gender,
                    LastUpdated = student.LastUpdated,
                    Name = student.Name,
                    Type = student.Type
                };

        }
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
            return studentStorage.Add(student);
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