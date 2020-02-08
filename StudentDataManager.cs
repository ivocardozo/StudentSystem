using System.Collections.Generic;
using StudentSystem.Models;
using System;
using System.Linq;

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
        public void Delete(int studentId)
        {
            var itemToRemove = students.Single(s => s.Id == studentId);
            students.Remove(itemToRemove);
        }
        public List<Student> GetAll()
        {
            List<Student> listCopied = students.ToList();
            return listCopied;
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
            studentStorage.Delete(studentId);
        }
        public List<Student> GetStudents()
        {
            return studentStorage.GetAll();
        }
        public List<Student> FilterByName(List<Student> students, string name)
        {
            return null;
        }

        public List<Student> FilterByType(List<Student> students, string type)
        {
            return null;
        }

        public List <Student> FilterByGender(List<Student> students, string gender)
        {
            return null;
        }
    }
}