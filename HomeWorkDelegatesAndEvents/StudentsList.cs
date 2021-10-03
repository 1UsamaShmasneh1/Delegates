using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkDelegatesAndEvents
{
    public class StudentsList
    {
        public static List<Student> students = new List<Student>();
        public static void Add(Student student)
        {
            students.Add(student);
        }
        public static void Remove(Student student)
        {
            students.Remove(student);
        }
        public static List<Student> Filter(FilterDelegate filterDelegate)
        {
            List<Student> filteredStudents = new List<Student>();
            foreach (Student student in students)
            {
                if (filterDelegate(student))
                    filteredStudents.Add(student);
            }
            return filteredStudents;
        }
        public static bool Contains(ContainDelegate containDelegate)
        {
            foreach (Student student in students)
            {
                if (containDelegate(student))
                    return true;
            }
            return false;
        }
        public static int Sum(SumDelegate sumDelegate)
        {
            int sum = 0;
            foreach (Student student in students)
            {
                sum += sumDelegate(student);
            }
            return sum;
        }
        public static decimal Average(SumDelegate sum, AverageDelegate averageDelegate)
        {
            return averageDelegate(Sum(sum),students.Count);
        }
    }
}
