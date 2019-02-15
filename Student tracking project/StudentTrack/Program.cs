using System;
using System.Collections.Generic;
using AskGetConsole;

namespace StudentTrack
{
    enum School
    {
        VTDK,
        MIT,
        Hogwarts
    }

    class Program
    {
        static List<Student> students = new List<Student>();

        static void Main(string[] args)
        {
            Logger.Log("Tracker started", priority: 0);
            PayRoll payroll = new PayRoll();
            payroll.PayAll();

            bool adding = true;

            while (adding)
            {
                try
                {
                    Logger.Log("Adding new student");
                    var student = new Student();

                    student.Name = ConsoleAsk.Ask("Type student name");
                    student.Grade = ConsoleAsk.AskInt("Type student grade");
                    student.School = (School) ConsoleAsk.AskInt("School name (type the corresponding number) \n 0: VTDK \n 1: MIT \n 2: Hogwarts");
                    student.Birthday = ConsoleAsk.Ask("Type student birthday");
                    student.Address = ConsoleAsk.Ask("Type student address");
                    student.Phone = ConsoleAsk.AskInt("Type student phone");

                    Student.Count++;
                    Console.WriteLine("Student count: {0}", Student.Count);

                    students.Add(student);

                    Console.WriteLine("Add another student? y/n");
                    if (Console.ReadLine().ToLower() != "y")
                        adding = false;
                }
                catch (FormatException msg)
                {
                    Console.WriteLine(msg.Message);
                }
                catch (Exception)
                {
                    Console.WriteLine("Eroor adding student, please try again");
                }
            }

            FindGrade("name");

            foreach (var student in students)
            {
                Console.WriteLine("Student name: {0} | Grade: {1} | Birthday: {2} | Address: {3}", student.Name, student.Grade, student.Birthday, student.Address);
            }

            ExportData();
        }

        static void ImportData()
        {
            var importedStudent = new Student("Augustas", 10, "November", "Something", 123456789);
        }

        static void ExportData()
        {
            foreach (var student in students)
            {
                switch (student.School)
                {
                    case School.VTDK:
                        Console.WriteLine("Exporting to VTDK");
                        break;
                    case School.MIT:
                        Console.WriteLine("Exporting to MIT");
                        break;
                    case School.Hogwarts:
                        Console.WriteLine("Exporting to Hogwarts");
                        break;
                }
            }
        }

        static void FindGrade(string name)
        {
            var found = students.Find(student => student.Name == name);
            Console.WriteLine("Student name: {0} | Grade: {1}", found.Name, found.Grade);
        }
    }

    class Member
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
    }

    class Student : Member
    {
        static public int Count { get; set; } = 0;

        public int Grade { get; set; }
        public string Birthday { get; set; }
        public School School { get; set; }

        public Student ()
        {

        }

        public Student (string name, int grade, string birthday, string address, int Phone)
        {
            Name = name;
            Grade = grade;
            Birthday = birthday;
            Address = address;
            Phone = Phone;
        }
    }
}
