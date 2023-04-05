// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;
using System.Linq;
using Newtonsoft.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

public class Student
{
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public int DateOfBirth { get; set; }
    public int Course { get; set; }
    public int GroupNumber { get; set; }
    public List<int> Grades { get; set; }

    public int number = 0;

}

public class Program
{
    public static void Main(string[] args)
    {
        /*List<Student> students = new List<Student>()
        {
            new Student
            {
                LastName = "Іванов", FirstName = "Іван", MiddleName = "Іванович", DateOfBirth = 2000, Course = 2,
                GroupNumber = 002, Grades = new List<int> { 4, 5, 3, 4, 5 }
            },
            new Student
            {
                LastName = "Захар", FirstName = "Артур", MiddleName = "Монахович", DateOfBirth = 2001, Course = 1,
                GroupNumber = 002, Grades = new List<int> { 3, 4, 5, 4, 3 }
            },
            new Student
            {
                LastName = "Кішко", FirstName = "Сидір", MiddleName = "Валерійович", DateOfBirth = 2000, Course = 2,
                GroupNumber = 003, Grades = new List<int> { 5, 4, 5, 4, 5 }
            },
            new Student
            {
                LastName = "Дядько", FirstName = "Віктор", MiddleName = "Вікторович", DateOfBirth = 2002, Course = 1,
                GroupNumber = 002, Grades = new List<int> { 4, 3, 4, 3, 4 }
            }
        };

        var orderedStudents = students.OrderBy(x => x.Course).ThenBy(y => y.LastName).ToList();
        foreach (var s in orderedStudents)
        {
            Console.WriteLine("{0} {1} {2}, {3} курс, {4} группа", s.LastName, s.MiddleName, s.FirstName, s.Course,
                s.GroupNumber);
        }

        var maxAverage = students.GroupBy(x => x.GroupNumber).Select(g => new
        {
            GroupNumber = g.Key,
            MathAverage = g.Average(s => s.Grades[0]),
            PhysicsAverage = g.Average(s => s.Grades[1]),
            ChemistryAverage = g.Average(s => s.Grades[2]),
            HistoryAverage = g.Average(s => s.Grades[3]),
            EnglishAverage = g.Average(s => s.Grades[4])
        });

        foreach (var group in maxAverage)
        {
            Console.WriteLine("Група " + group.GroupNumber);
            Console.WriteLine("Середній бал по математиці: " + group.MathAverage);
            Console.WriteLine("Середній бал по фізиці: " + group.PhysicsAverage);
            Console.WriteLine("Середній бал по хімії: " + group.ChemistryAverage);
            Console.WriteLine("Середній бал по історії: " + group.HistoryAverage);
            Console.WriteLine("Середній бал по англійській мові: " + group.EnglishAverage);
        }

        /*var minDate = students.Min(x => x.DateOfBirth);#1#


        int youngest = 2023;
        int oldest = 0;
        foreach (var student in students)
        {
            if (student.DateOfBirth > oldest)
            {
                oldest = student.DateOfBirth;
            }

            if (student.DateOfBirth < youngest)
            {
                youngest = student.DateOfBirth;
            }

        }

        foreach (var student in students)
        {
            if (student.DateOfBirth == oldest)
            {
                Console.WriteLine($"Найстарший студент  {student.LastName}");
            }

            if (student.DateOfBirth == youngest)
            {
                Console.WriteLine($"Наймолодший студент  {student.LastName}");
            }
        }

        int groupNum = 002;
        int sumsum = 0;
        int sumsum2 = 0;
        int grpNum;
        foreach (var student in students)
        {
            if (student.GroupNumber == groupNum)
            {
                if (sumsum < student.Grades.Sum())
                {
                    sumsum = student.Grades.Sum();
                    Console.WriteLine(
                        $"Найуспішніший студент групи {student.GroupNumber} це {student.LastName} {student.FirstName}");
                }
            }
            else
            {
                if (sumsum2 < student.Grades.Sum())
                {
                    sumsum2 = student.Grades.Sum();
                    Console.WriteLine(
                        $"Найуспішніший студент групи {student.GroupNumber} це {student.LastName} {student.FirstName}");
                }
            }
        }*/

        /*Dictionary<string, int> d = new Dictionary<string, int>()
        {
            ["Молоко"] = 200,
            ["Чорна ікра"] = 450,
            ["Хліб"] = 145,
            ["Краб"] = 600,
            ["Шоколад"] = 70
        };
        Console.WriteLine("Список продуктів:");
        foreach (var j in d)
        {
            Console.WriteLine(j);
        }
        
        
        var newlist = d.Where(i => i.Value > 300);
        Console.WriteLine("Товар дорожче 300 гривень: ");
        foreach (var j in newlist)
        {
            Console.WriteLine(j);
        }
        var newlist2 = d.Where(i => i.Value < 300);
        Console.WriteLine("Товар дешевше 300 гривень: ");
        foreach (var j in newlist2)
        {
            Console.WriteLine(j);
        }*/

        //--------------------------------------------------------------

        Dictionary<int, int> d1 = new Dictionary<int, int>()
        {
            [0] = 0,
            [1] = 13,
            [2] = 14,
            [6] = 45,
            [78] = 7
        };
        int maxKey = int.MinValue;
        foreach (var key in d1.Keys)
        {
            if (key > maxKey)
            {
                maxKey = key;
            }
        }
        d1.Remove(maxKey);

        int minKey = int.MaxValue;
        foreach (var key2 in d1.Keys)
        {
            if (minKey > key2)
            {
                minKey = key2;
            }
        }

        minKey = maxKey;
        Console.WriteLine(minKey);

        string json = JsonConvert.SerializeObject(minKey);
        Console.WriteLine(json);
        
        string file = "D:\\Json\\1.txt";
        StreamWriter sw = new StreamWriter(file);
        sw.Write(json);
        sw.Close();
        StreamReader sr = new StreamReader(file);
        string jsonnew = sr.ReadToEnd();
        sr.Close();
        Console.WriteLine(jsonnew);
        //---------------------------------------------------------

    }
} 

