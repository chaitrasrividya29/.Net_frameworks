namespace ConsoleApp1
{
    public class LingSamples
    {
        static void Main(string[] args)
        {
            List<UGStudent> students = new List<UGStudent>();
            List<int> studentsIds = new List<int> ();
            students.Add(new UGStudent { Name = "chaitra", RollNo = 1 });
            students.Add(new UGStudent { Name = "sri", RollNo = 2});
            students.Add(new UGStudent { Name = "vidya", RollNo = 3});
            students.Add(new UGStudent { Name = "laxmi", RollNo = 4 });
            students.Add(new UGStudent { Name = "sai", RollNo = 5 });

            var filteredStudents = students.Where(s => s.RollNo > 2).ToList();
            foreach (var student in filteredStudents)
            {
                Console.WriteLine(student.Name);
            }

        }


    }

    public class UGStudent


    {
        public string Name { get; set; }
        public int RollNo { get; set; }
    }

}
