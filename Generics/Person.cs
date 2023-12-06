using System;
using System.Collections;
using System.Diagnostics;
using System.Reflection;
using System.Xml.Linq;

namespace Generics
{
    public abstract class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        protected Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public abstract int CompareTo(Person? obj);
    }
    public class Teacher : Person
    {
        public string Subject { get; set; }

        public Teacher(string name, int age, string subject) : base(name, age)
        {
            Subject = subject;
        }

        public override int CompareTo(Person? obj)
        {
            return Subject.CompareTo((obj as Teacher).Subject);
        }

        static public Teacher Generate()
        {
            string[] names = { "Ярик", "Влад", "Никита", "Паша", "Глеб", "Аня", "Павел" };
            string[] subjs = { "География", "Информатика", "Биология", "Психология", "Математика" };
            Random rnd = new();
            return new Teacher(names[rnd.Next(0, names.Length)], rnd.Next(18, 100), subjs[rnd.Next(0, subjs.Length)]);
        }
        public override string ToString()
        {
            return $"{'{'}\n \t Имя: {Name},\n \t Возраст: {Age},\n \t Предмет: {Subject} \n{'}'}";
        }
    }

    public class Student : Person
    {
        public string Grade { get; set; }
        public Student(string name, int age, string grade) : base(name, age)
        {
            Grade = grade;
        }

        public override int CompareTo(Person? obj)
        {
            return Grade.CompareTo((obj as Student).Grade);
        }

        static public Student Generate()
        {
            string[] names = { "Ярик", "Влад", "Никита", "Паша", "Глеб", "Аня", "Павел" };
            string[] subjs = { "Высшее", "Профессиональное", "Среднее основное", "Среднее общее", "Кандидат наук" };
            Random rnd = new();
            return new Student(names[rnd.Next(0, names.Length)], rnd.Next(18, 23), subjs[rnd.Next(0, subjs.Length)]);
        }

        public override string ToString()
        {
            return $"{'{'}\n \t Имя: {Name},\n \t Возраст: {Age},\n \t Образование: {Grade} \n{'}'}";
        }
    }
}
