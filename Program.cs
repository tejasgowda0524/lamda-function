namespace lamda
{

    public class dog
    {
        public  string name { set; get; }
        public  int age { set; get; } 
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> m = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> evennumbers = m.FindAll(v => (v%2)==0);

            foreach (int i in evennumbers)
            {
                Console.WriteLine(i);
            }







            List<dog> li = new List<dog>()
            {
               new dog { name = "rex" , age =4 },
               new dog { name = "mah" ,age =5 },
               new dog { name="gohu",age =6 }
            };

            var names = li.OrderByDescending(x => x.age);

            foreach (var na in names)
            {
                Console.WriteLine(string.Format("dog {0} is {1} year old.", na.name, na.age));
            }




            List<string> list = new List<string>() { "appl", "orange", "grapes", "banana" };

            var words = list.OrderBy(m => m.Length);

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }



            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            var groupedNumbers = numbers.GroupBy(n => n % 2 == 0 ? "Even" : "Odd");

            foreach (var number in groupedNumbers)
            {
                Console.WriteLine(number);
            }
            
        }
    }
}
