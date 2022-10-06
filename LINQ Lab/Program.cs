namespace LINQ_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 10, 2330, 112233, 10, 949, 3764, 2942 };

            int lowest = nums.Min();
            Console.WriteLine(lowest);
            Console.WriteLine();
            int highest = nums.Max();
            Console.WriteLine(highest);
            Console.WriteLine();
            int highestUnder10k = nums.Where(x => x < 10000).Max();
            Console.WriteLine(highestUnder10k);
            Console.WriteLine();
            List<int> between10and100 = nums.Where(x => x >= 10 && x <= 100).ToList();
            PrintList(between10and100);
            Console.WriteLine();
            List<int> between10kandMil = nums.Where(x => x >= 100000 && x <= 999999).ToList();
            PrintList(between10kandMil);
            Console.WriteLine();
            int evenCount = nums.Count(x => x % 2 == 0);
            Console.WriteLine(evenCount);
            Console.WriteLine();
            List<int> descending = nums.OrderByDescending(num => num).ToList();
            PrintList(descending);
            Console.WriteLine();


            List<Student> students = new List<Student>();
            students.Add(new Student("Jimmy", 13));
            students.Add(new Student("Hannah Banana", 21));
            students.Add(new Student("Justin", 30));
            students.Add(new Student("Sarah", 53));
            students.Add(new Student("Hannibal", 15));
            students.Add(new Student("Phillip", 16));
            students.Add(new Student("Maria", 63));
            students.Add(new Student("Abe", 33));
            students.Add(new Student("Curtis", 10));

            List<Student> drinkingAge = students.Where(s => s.Age >= 21).ToList();
            PrintStudent(drinkingAge);
            Console.WriteLine();

            int oldest = students.Max(s => s.Age);
            List<Student> oldestStudent = students.Where(s => s.Age == oldest).ToList();
            PrintStudent(oldestStudent);
            Console.WriteLine();

            int youngest = students.Min(s => s.Age);
            List<Student> youngestStudent = students.Where(s=>s.Age == youngest).ToList();
            PrintStudent(youngestStudent);
            Console.WriteLine();

            List<Student> sub25 = students.Where(s => s.Age < 25).ToList();
            int oldest2 = sub25.Max(s => s.Age);
            List<Student> oldestSub25 = sub25.Where(s => s.Age == oldest2).ToList();
            PrintStudent(oldestSub25);
            Console.WriteLine();

            List<Student> evenAbove21 = drinkingAge.Where(s => s.Age % 2 == 0).ToList();
            PrintStudent(evenAbove21);
            Console.WriteLine();

            List<Student> teenagers = students.Where(s => s.Age >= 13 && s.Age <= 19).ToList();
            PrintStudent(teenagers);
            Console.WriteLine();

            char[] vowels = { 'A', 'E', 'I', 'O', 'U' };
            List<Student> vowel = students.Where(s => vowels.Contains(s.Name[0])).ToList();
            PrintStudent(vowel);
            Console.WriteLine();

            List<Student> ascending = students.OrderBy(students => students.Age).ToList();
            PrintStudent(ascending);
            Console.WriteLine();
        }
        public static void PrintList(List<int> input)
        {
            for (int i = 0; i < input.Count; i++)
            {
                int num = input[i];
                Console.WriteLine($"{i}: {num}");
            }
        }
        public static void PrintStudent(List<Student> pupil)
        {
            for(int i = 0; i < pupil.Count; i++)
            {
                Student s = pupil[i];
                Console.WriteLine($"{s.Name}: {s.Age}");
            }
        }
    }
}