namespace CAYONA_Act2
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Welcome to Cafe Perene. To book reservation kindly provide the following details.");
             Console.Write("Name: ");
             string name = Console.ReadLine();
             Console.Write("Date (yyyy-mm-dd): ");
             DateTime date = DateTime.Parse(Console.ReadLine());
             Console.Write("For how many people: ");
             int age = int.Parse(Console.ReadLine());


            Console.WriteLine("Thank you for choosing Cafe Perene! Here are the details for your reservation");
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Date: {date.ToString("yyyy-MM-dd")}");
                Console.WriteLine($"Number of People: {age}");  
            Console.WriteLine("We look forward to serving you at Cafe Perene!");
        }
    }
}

