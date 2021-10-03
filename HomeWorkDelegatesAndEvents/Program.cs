using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWorkDelegatesAndEvents
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MyFirstDelegate print1 = new MyFirstDelegate(Print1);
            MyFirstDelegate print2 = new MyFirstDelegate(Print2);
            Greet greet = new Greet(Print3);
            CalculationDelegate calc1 = new CalculationDelegate(Add);
            CalculationDelegate calc2 = new CalculationDelegate(Sub);
            bool isContain1 = StudentsList.Contains(IsContainsGradeMoreThan50);
            bool isContain2 = StudentsList.Contains(IsContainsSameFirstChar);
            int amountHasBeenPaied = StudentsList.Sum(MoneyHasPaied);
            int amountNotPaied = StudentsList.Sum(MoneyNeedToPay);
            decimal ageAvg = StudentsList.Average(Grade, Average);
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
        public static void Print1()
        {
            Debug.WriteLine("Shalom");
        }
        public static void Print2()
        {
            Debug.WriteLine("e same with called function Ano");
        }
        public static void Print3(string name)
        {
            Debug.WriteLine($"Welcome {name}");
        }
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Sub(int num1, int num2)
        {
            return num1 - num2;
        }
        public static bool IsContainsGradeMoreThan50(Student student)
        {
            if (student.Grade > 50)
                return true;
            return false;
        }
        public static bool IsContainsSameFirstChar(Student student)
        {
            if (student.FirstName.ToLower()[0] == student.LastName.ToLower()[0])
                return true;
            return false;
        }
        public static int MoneyHasPaied(Student student)
        {
            return student.AmountPaid;
        }
        public static int MoneyNeedToPay(Student student)
        {
            return student.AmountToPay;
        }
        public static int Grade(Student student)
        {
            return student.Grade;
        }
        public static decimal Average(int sum, int studentsCount)
        {
            return sum / studentsCount;
        }
    }
}
