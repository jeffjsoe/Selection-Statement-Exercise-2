
using System.Security.Cryptography.X509Certificates;

namespace SelectionStatementExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your favorite subject");

            var favSubject = Console.ReadLine();
            
            //We will call the method and store favsubject in the statment
            var subject = Statement(favSubject);
            Console.WriteLine(subject);
            //Create a method which returns what the response is based on the user input

            static string Statement(string favSubject)
            {
                switch (favSubject.ToLower())
                {
                    case "science":
                       return ("Pretty tough subject"!);
                        break;
                    case "math":
                        return ("Love the course");
                        break;
                    case "computer science":
                        return ("Who doesnt love that class");
                        break;
                    case "religion":
                        return ("Never took it before, but I think its cool!");
                        break;
                    case "business":
                        return ("You trying to make that money right");
                        break;
                    default:
                        return ("Intresting subject!");
                        break;

                }




            }



        }
    }
}
