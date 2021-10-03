using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvent
{
    public class StudentTable
    {
        public delegate bool StudentsFilterDelegate(Student student);
        public static Ilogger Logger {  get; set; }
        public static LogDelegate Log {  get; set; }
        public static List<Student> Students { get; set; } = new List<Student>();
        public static void Add(Student student)
        {
            //Logger.Log("Added" + student.Name")
            Log("Added" + student.Name);
        }
        public static void Remove(Student student, LogDelegate logParam)
        {
            Students.Remove(student);
            logParam("Removed" + student.Name);
        }
        public List<Student> Filter(StudentsFilterDelegate studentsFilterDelegate)
        {
            var list = new List<Student>();
            foreach (Student student in Students)
            {
                if(studentsFilterDelegate(student))
                    list.Add(student);
            }
            return list;
        }
    }
}
