using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab___5___classes_constructor
{

    class Student
    {
        public string Name;
        public int Course;
        public bool Scolarship;

        public Student()
        {

        }

        public Student(string name)
        {
            this.Name = name;
        }

        public Student(string name, int course)
        {
            this.Name = name;
            this.Course = course;
        }

        public Student(string name, int course, bool scolarship)
        {
            this.Name = name;
            this.Course = course;
            this.Scolarship = scolarship;
        }

        public void Report()
        {
            if (Course==0)
                Console.WriteLine(" Student name: {0}\n Course: Unnown\n Scolarship status: {1}\n\n", Name, Scolarship);
            else
                Console.WriteLine(" Student name: {0}\n Course: {1}\n Scolarship status: {2}\n\n", Name, Course, Scolarship);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Student John = new Student("John");
            John.Report();
            Student Derek = new Student("Derek", 2);
            Derek.Report();
            Student Alisha = new Student("Alisha", 3, true);
            Alisha.Report();
            Console.ReadKey();
        }
    }
}
