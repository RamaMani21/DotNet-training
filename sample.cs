using system;

namespace CSharpFundamentals
{
      public class sample  

       {
          public static void Main(string[] args)

            {

               int empAge;
               string empName;

                Console.WriteLine("Enter employee name\n");
                empName = Console.ReadLine();
                Console.WriteLine("Enter employee age\n");
                empAge = int.Parse(Console.ReadLine());  
                Console.WriteLine("Congratulations Mr/Miss {0} on your {1} Birthday", empName, empAge);

                



             }
        }


}
