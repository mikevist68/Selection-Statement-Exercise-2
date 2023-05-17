namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static void FavSubject()
        {

            Console.WriteLine("Whats your favorite subject?");
            var subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("I uesd to like math");
                    break;
                case "science":
                    Console.WriteLine("Science is okay");
                    break;
                case "pe":
                    Console.WriteLine("I miss pe");
                    break;
                case "history":
                    Console.WriteLine("History was fun sometimes");
                    break;
                case "music":
                    Console.WriteLine("I had alot of fun in music class");
                    break;
                default:
                    Console.WriteLine("Oops forgot about that one");
                    break;
            }



        }


     }


}        
        
        
        
        
        
        
    
