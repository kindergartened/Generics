using System.Collections.Generic;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        Random rnd = new Random();
        [TestMethod]
        public void TestStrings()
        {
            List<string> list = new();
            string ñhars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            for (int i = 0; i < 1000; i++)
            {
                list.Add(new string(Enumerable.Repeat(ñhars, rnd.Next(10, 50)).Select(s => s[rnd.Next(s.Length)]).ToArray()));
            }
            List<string> list2 = new(list);
            list2.Sort();
            list = UniversalSortings.QuickSort(list);
            CollectionAssert.AreEqual(list, list2);
        }
        [TestMethod]
        public void TestNums()
        {
            List<int> list = new();
            for (int i = 0; i < 1000; i++)
            {
                list.Add(rnd.Next(-10000, 10000));
            }
            List<int> list2 = new(list);
            list2.Sort();
            list = UniversalSortings.QuickSort(list);
            CollectionAssert.AreEqual(list, list2);
        }
        [TestMethod]
        public void TestBools()
        {
            List<bool> list = new();
            for (int i = 0; i < 1000; i++)
            {
                list.Add(rnd.Next(0, 2) == 1 ? true : false);
            }
            List<bool> list2 = new(list);
            list2.Sort();
            list = UniversalSortings.QuickSort(list);
            CollectionAssert.AreEqual(list, list2);
        }
        [TestMethod]
        public void TestTeachers()
        {
            List<Teacher> list = new();
            for (int i = 0; i < 1000; i++)
            {
                list.Add(Teacher.Generate());
            }
            List<Teacher> list2 = new(list);
            list2 = list2.OrderBy(p => p.Subject).ToList();
            list = UniversalSortings.QuickSort(list);
            List<string> subjs = list.Select(p => p.Subject).ToList();
            List<string> subjs2 = list2.Select(p => p.Subject).ToList();
            CollectionAssert.AreEqual(subjs, subjs2);
        }
        [TestMethod]
        public void TestStudents()
        {
            List<Student> list = new();
            for (int i = 0; i < 1000; i++)
            {
                list.Add(Student.Generate());
            }
            List<Student> list2 = new(list);
            list2 = list2.OrderBy(p => p.Grade).ToList();
            list = UniversalSortings.QuickSort(list);
            List<string> subjs = list.Select(p => p.Grade).ToList();
            List<string> subjs2 = list2.Select(p => p.Grade).ToList();
            CollectionAssert.AreEqual(subjs, subjs2);
        }
        [TestMethod]
        public void TestSmartHome()
        {
            List<SmartHome<AssistantSpeaker, Lights, CleaningService, SecurityService>> list = new();
            for (int i = 0; i < 1000; i++)
            {
                list.Add(SmartHome<AssistantSpeaker, Lights, CleaningService, SecurityService>.Generate());
            }
            List<SmartHome<AssistantSpeaker, Lights, CleaningService, SecurityService>> list2 = new(list);
            list2 = list2.OrderBy(p => p.TotalSum).ToList();
            list = UniversalSortings.QuickSort(list);
            List<int> subjs = list.Select(p => p.TotalSum).ToList();
            List<int> subjs2 = list2.Select(p => p.TotalSum).ToList();
            CollectionAssert.AreEqual(subjs, subjs2);
        }
    }
}