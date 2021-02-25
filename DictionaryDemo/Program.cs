using System;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> students = new MyDictionary<int, string>();
            students.Add(7, "Kürşad Kırkçeri");
            students.Add(207,"Metehan Oğuzbeyi");
            students.Add(1453,"Fatih Mehmet");
            students.Add(1923, "Mustafa Kemal");
            students.Add(1299, "Osman Gazibey");
            students.Add(1336, "Emir Timur");
            Console.WriteLine(students.count);
        }
    }
}
